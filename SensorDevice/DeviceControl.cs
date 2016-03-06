
namespace SensorDevices
{
    public interface DeviceControl
    {
        void powerOff();
        int getFirmwareVersion();
        long getSystemUptime();
    }
}
