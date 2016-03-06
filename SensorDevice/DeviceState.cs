using System;

namespace SensorDevices
{
    public interface DeviceState
    {
        void enable();
        void disable();
        bool isEnabled();
        DateTime isEnabledSince();
    }
}
