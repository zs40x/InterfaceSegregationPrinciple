
namespace SensorDevices
{
    public interface SensorReading
    {
        int getLastReading();
        int getMinReading();
        int getMaxReading();
        int getAvgReading();
    }
}
