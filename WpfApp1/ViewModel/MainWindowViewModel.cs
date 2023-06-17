using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using WpfApp.MVVM;
using WpfApp1.Model;
using WpfApp1.Service;

namespace WpfApp1.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private MeasurementService _service;
        private Measurement lastMeasurement;
        private List<Measurement> measurements;

        public MainWindowViewModel()
        {
            _service = new MeasurementService();
            GetMeasurementCommand = new Command(GetMeasurement);
        }

        public Command GetMeasurementCommand { get; set; }

        public List<Measurement> Measurements { get => measurements; set => Set(ref measurements, value); }

        public Measurement LastMeasurement
        {
            get => lastMeasurement;
            set => Set(ref lastMeasurement, value);
        }
        public async void GetMeasurement()
        {
            Measurements = await _service.GetMeasurements(1000);
            LastMeasurement = Measurements.Last();
        }
    }
}
