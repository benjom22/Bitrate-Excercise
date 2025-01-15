using Bitrate_Exercise;
class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\benjo\\source\\repos\\Bitrate Exercise\\deviceInfo.json";
        double poolingRate = 0.5;

        try
        {
            if (!Parser.TryParse(filePath, out var deviceInfo))
            {
                Console.WriteLine($"Unable to parse device info from file: {filePath}");
                return;
            }

            ShowResult(deviceInfo, poolingRate);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private static void ShowResult(DeviceInfo deviceInfo, double poolingRate)
    {
        Console.WriteLine($"Device: {deviceInfo.Device}");
        Console.WriteLine($"Model: {deviceInfo.Model}");
        foreach (var nic in deviceInfo.NIC)
        {
            Console.WriteLine($"NIC: {nic.Description}");
            Console.WriteLine($"MAC: {nic.MAC}");
            Console.WriteLine($"Timestamp: {nic.Timestamp}");
            Console.WriteLine($"Total Bitrate: {nic.CalculatedBitrate(poolingRate)} bps");
        }
    }
}
