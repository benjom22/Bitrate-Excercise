using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json;

namespace Bitrate_Exercise
{

    public static class Parser
    {
        public static bool TryParse(string filePath, out DeviceInfo deviceInfo)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                deviceInfo = JsonConvert.DeserializeObject<DeviceInfo>(jsonContent);
                return deviceInfo != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing JSON file: {ex.Message}");
                throw;
            }
        }
    }

}
