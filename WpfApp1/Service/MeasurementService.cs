using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Service
{
    public class MeasurementService
    {
        private Random _rand;

        public MeasurementService()
        {
            _rand = new Random(DateTime.Now.Millisecond);
        }
        public async Task<Measurement> Read()
        {
            await Task.Delay(5);
            return new Measurement
            {
                Time = DateTime.Now,
                Temperature = _rand.Next(18, 29),
                Pressure = _rand.Next(980, 1100)
            };
        }

        public async Task<List<Measurement>> GetMeasurements(int amount)
        {
            var output = new List<Measurement>();

            for (var i = 0; i < amount; i++)
            {
                output.Add(await Read());
            }

            return output;
        }
    }
}
