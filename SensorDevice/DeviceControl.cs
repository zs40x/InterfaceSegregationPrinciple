
namespace SensorDevice
{
    interface DeviceControl
    {
        void powerOff();
        int getFirmwareVersion();
        long getSystemUptime();
    }
}
