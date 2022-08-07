namespace WheelchairProject;

public interface IManufacturable
{
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public string? BuildStatus { get; set; }
}