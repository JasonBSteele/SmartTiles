using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartTiles.Models;

namespace SmartTiles.Services
{
    public class TemperatureDevicesService : ITemperatureDevicesService
    {
        private readonly IHttpService _httpService;

        public TemperatureDevicesService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<TemperatureDevice>> GetTemperatureDevices()
        {
            var json = await _httpService.Get("temperatures");
            var temperatures = JsonConvert.DeserializeObject<IEnumerable<TemperatureDevice>>(json);
            return temperatures;
        }
    }
}
