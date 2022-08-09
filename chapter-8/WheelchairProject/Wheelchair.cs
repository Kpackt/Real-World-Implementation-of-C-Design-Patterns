namespace WheelchairProject;
using WheelchairComponents;
public abstract class Wheelchair : WheelchairComponent, IManufacturable
{
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public WheelchairSeat Seat { get; set; }
    public WheelchairFrame Frame { get; set; }
    public string? BuildStatus { get; set; }
    
    protected Wheelchair()
    {
        ModelName = string.Empty; // will be filled in subclass constructor
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year; 
    }
}