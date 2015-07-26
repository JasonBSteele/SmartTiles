using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartTiles.Services;

namespace SmartTiles.Test
{
    [TestClass]
    public class TemperatureServiceTests
    {
        private const string BaseUrl =
            "https://graph.api.smartthings.com/api/smartapps/installations/cdfce823-576c-46ee-8ba5-d23dbf89c5f0/";

        private const string AccessToken = "Bearer f4f095ab-ff4d-4408-9373-a5bc2cf4e801";
            
        [TestMethod]
        public async Task GetTemperatures_ReturnsTemperatures()
        {
            var temperatureDevicesService = new TemperatureDevicesService(new HttpService(BaseUrl, AccessToken));
            var temperatureDevices = await temperatureDevicesService.GetTemperatureDevices();

            Assert.IsTrue(temperatureDevices.Any(), "No temperature devices were returned");
        }
    }
}
