using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartTiles.Helpers;

namespace SmartTiles.Models
{
    public class SwitchDevice : BaseDevice
    {
        [JsonProperty(PropertyName = "switch")]
        [JsonConverter(typeof(JsonSwitchConverter))]
        public bool IsOn { get; set; }
    }
}
