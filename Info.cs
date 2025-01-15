using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Bitrate_Exercise
{
    public class Nic
    {
        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("MAC")]
        public string MAC { get; set; }

        [JsonProperty("Timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("Rx")]
        public long Rx { get; set; }

        [JsonProperty("Tx")]
        public long Tx { get; set; }

        public double CalculatedBitrate(double pollingRate)
        {
            return (Rx + Tx) * 8 / pollingRate;
        }
    }

    public class DeviceInfo
    {
        [JsonProperty("Device")]
        public string Device { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

        [JsonProperty("NIC")]
        public List<Nic> NIC { get; set; }
    }

}
