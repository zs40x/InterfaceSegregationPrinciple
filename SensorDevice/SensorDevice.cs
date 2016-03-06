using System;

namespace SensorDevice
{
    interface SensorDevice
    {
        void powerOff();
        void enable();
        void disable();

        bool isEnabled();
        DateTime isEnabledSince();
        int getFirmwareVersion();
        long getSystemUptime();
        int getLastReading();
        int getMinReading();
        int getMaxReading();
        int getAvgReading();
    }
}
