using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Measurement
    {
        public DateTime Time { get; set; }
        public double Temperature { get; set; }
        public double Pressure { get; set; }
    }
}
