using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SmartTiles.Models;
using Newtonsoft.Json;

namespace SmartTiles.Services
{
    public class SwitchDevicesService : ISwitchDevicesService
    {
        private readonly IHttpService _httpService;

        public SwitchDevicesService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<SwitchDevice>> GetSwitchDevices()
        {
            var json = await _httpService.Get("switches");
            var switches = JsonConvert.DeserializeObject<IEnumerable<SwitchDevice>>(json);
            return switches;
        }
    }
}
