using SensorDevices;
using System;

namespace FakeSensors
{
    public class ConsoleLogFakeSensor : SensorDevice
    {
        public void disable()
        {
            debugLog("disable()");
        }

        public void enable()
        {
            debugLog("enable()");
        }

        public int getAvgReading()
        {
            debugLog("getAvgReading()");

            return 0;
        }

        public int getFirmwareVersion()
        {
            debugLog("getFirmwareVersion()");

            return 0;
        }

        public int getLastReading()
        {
            debugLog("getLastReading()");

            return 0;
        }

        public int getMaxReading()
        {
            debugLog("getMaxReading()");

            return 0;
        }

        public int getMinReading()
        {
            debugLog("getMinReading()");

            return 0;
        }

        public long getSystemUptime()
        {
            debugLog("getSystemUptime()");

            return 0;
        }

        public bool isEnabled()
        {
            debugLog("isEnabled()");

            return false;
        }

        public DateTime isEnabledSince()
        {
            debugLog("isEnabledSince()");

            return DateTime.Now;
        }

        public void powerOff()
        {
            debugLog("powerOff()");
        }


        private void debugLog(string message)
        {
            Console.WriteLine(message, ConsoleColor.White);
        }
    }
}
