namespace MobilityLibrary;

public abstract class WheelChair : IMobilityDevice
{
    public string ModelName { get; set; }
    public int Year { get; set; }
    public string SerialNumber { get; }

    protected WheelChair()
    {
        ModelName = string.Empty;
        Year = DateTime.Now.Year;
        SerialNumber = Guid.NewGuid().ToString();
    }
}