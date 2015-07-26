using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTiles.Services;
using XLabs.Forms.Mvvm;
using SmartTiles.Models;

namespace SmartTiles.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly ITemperatureDevicesService _temperatureDevicesService;
        
        /// <summary>
        /// Use the async constructor pattern described here http://blog.stephencleary.com/2013/01/async-oop-2-constructors.html
        /// </summary>
        public Task Initialization { get; private set; }

        public IEnumerable<TemperatureDevice> TemperatureDevices
        {
            get { return _temperatureDevices; }
            private set
            {
                SetProperty(ref _temperatureDevices, value);
            }
        }
        private IEnumerable<TemperatureDevice> _temperatureDevices = null;
        

        public MainViewModel(ITemperatureDevicesService temperatureDevicesService)
        {
            _temperatureDevicesService = temperatureDevicesService;

            Initialization = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await LoadTemperatureTiles();
        }

        private async Task LoadTemperatureTiles()
        {
            try
            {
                TemperatureDevices = await _temperatureDevicesService.GetTemperatureDevices();
            }
            catch (Exception)
            {
                //TODO Let the user know that something has gone wrong
                throw;
            }
                
        }
    }
}
