using System.Collections.Generic;
using System.Threading.Tasks;
using SmartTiles.Models;

namespace SmartTiles.Services
{
    public interface ITemperatureDevicesService
    {
        Task<IEnumerable<TemperatureDevice>> GetTemperatureDevices();
    }
}