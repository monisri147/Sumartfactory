using System;

namespace DeviceMonitor
{
    class TemperatureModule
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temperature Module Running...");

            VibrationModule.Run();
        }
    }

    class VibrationModule
    {
        public static void Run()
        {
            Console.WriteLine("Vibration Module Running...");
        }
    }
}
