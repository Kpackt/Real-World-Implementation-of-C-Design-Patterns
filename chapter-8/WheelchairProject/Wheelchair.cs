namespace WheelchairProject;
using WheelchairComponents;
public abstract class Wheelchair : WheelchairComponent, IManufacturable
{
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public string? BuildStatus { get; set; }
    
    protected Wheelchair()
    {
        ModelName = string.Empty; // will be filled in subclass constructor
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year; 
    }
}