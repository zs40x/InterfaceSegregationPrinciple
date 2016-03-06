using System;

namespace SensorDevice
{
    interface DeviceState
    {
        void enable();
        void disable();
        bool isEnabled();
        DateTime isEnabledSince();
    }
}
