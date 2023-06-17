using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Service
{
    public class MeasurementService
    {
        public Measurement Read()
        {
            return new Measurement
            {
                Time = DateTime.Now,
                Temperature = 21,
                Pressure = 1045
            };
        }
    }
}
