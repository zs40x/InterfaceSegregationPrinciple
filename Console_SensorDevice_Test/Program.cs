using SensorDevices;
using FakeSensors;
using System;

namespace Console_SensorDevice_Test
{
    static class Program
    {
        static void Main()
        {
            SensorDevice sensor = new ConsoleLogFakeSensor();
            sensor.enable();

            DeviceState sensorState = sensor;
            sensorState.isEnabledSince();
            sensorState.disable();

            DeviceControl sensorControl = sensor;
            sensor.powerOff();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}