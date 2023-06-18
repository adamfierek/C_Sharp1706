using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;
using System.Text.Json;


namespace TestApp.Services
{
    public class ApiService
    {
        private HttpClient _client;
        private JsonSerializerOptions _options;
        public ApiService(string url)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };
            _options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        public async Task SendMeasurement(Measurement measurement)
        {
            var json = JsonSerializer.Serialize(measurement, _options);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _client.PostAsync("/measurement", content);
        }

        public async Task<List<Measurement>> GetMeasurements()
        {
            var response = await _client.GetAsync("/measurement");
            var content = await response.Content.ReadAsStringAsync();

            var list = JsonSerializer.Deserialize<List<Measurement>>(content, _options);

            return list;
        }
    }
}
