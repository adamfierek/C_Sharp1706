using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.MVVM;
using WpfApp1.Model;
using WpfApp1.Service;

namespace WpfApp1.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private MeasurementService _service;
        private Measurement lastMeasurement;

        public MainWindowViewModel()
        {
            _service = new MeasurementService();
            GetMeasurementCommand = new Command(GetMeasurement);
        }

        public Command GetMeasurementCommand { get; set; }

        public Measurement LastMeasurement
        {
            get => lastMeasurement;
            set
            {
                lastMeasurement = value;
                OnPropertyChanged();
            }
        }
        public void GetMeasurement()
        {
            LastMeasurement = _service.Read();
        }
    }
}
