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
            "YOUR BASE URL HERE";

        private const string AccessToken = "Bearer YOUR ACCESS TOKEN HERE";
            
        [TestMethod]
        public async Task GetTemperatures_ReturnsTemperatures()
        {
            var temperatureDevicesService = new TemperatureDevicesService(new HttpService(BaseUrl, AccessToken));
            var temperatureDevices = await temperatureDevicesService.GetTemperatureDevices();

            Assert.IsTrue(temperatureDevices.Any(), "No temperature devices were returned");
        }
    }
}
