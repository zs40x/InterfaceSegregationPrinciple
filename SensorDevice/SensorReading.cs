
namespace SensorDevice
{
    interface SensorReading
    {
        int getLastReading();
        int getMinReading();
        int getMaxReading();
        int getAvgReading();
    }
}
