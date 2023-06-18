using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Interop;
using TestApp.Models;
using TestApp.Services;
using WpfApp.MVVM;


namespace WpfApp1.ViewModel
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private MeasurementService _service;
        private ApiService _apiService;
        private Measurement lastMeasurement;
        private List<Measurement> measurements;

        public MainWindowViewModel()
        {
            _service = new MeasurementService();
            _apiService = new ApiService("http://127.0.0.1:5000");
            GetMeasurementCommand = new Command(GetMeasurement);
            RunPInvoke = new Command(RunPInvokeCommand);
            Task.Run(async () =>
            {
                Measurements = await _apiService.GetMeasurements();
            });
        }

        private void RunPInvokeCommand()
        {
            var hWindow = new WindowInteropHelper(Application.Current.MainWindow).Handle;
            MessageBox(hWindow, "Hello from P/Invoke", "Message", 0);
        }

        public Command GetMeasurementCommand { get; set; }
        public Command RunPInvoke { get; private set; }
        public List<Measurement> Measurements { get => measurements; set => Set(ref measurements, value); }

        public Measurement LastMeasurement
        {
            get => lastMeasurement;
            set => Set(ref lastMeasurement, value);
        }
        public async void GetMeasurement()
        {
            /*Measurements = await _service.GetMeasurements(1000)*/;
            var measurement = await _service.Read();
            LastMeasurement = measurement;
            await _apiService.SendMeasurement(measurement);
            Measurements = await _apiService.GetMeasurements();
        }
    }
}
