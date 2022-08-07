namespace MobilityLibrary;

public interface IMobilityDevice
{
    public string ModelName { get; set; }
    public int Year { get; set; }
    public string SerialNumber { get; }
    
}