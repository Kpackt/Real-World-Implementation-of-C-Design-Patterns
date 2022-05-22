namespace BumbleBikesLibrary.PaintableBicycle;

public abstract class SimplifiedBicycle : ISimplifiedBicycle
{
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public BicycleGeometries Geometry { get; set; }
    public SuspensionTypes Suspension { get; set; }
    public ManufacturingStatus BuildStatus { get; set; }

    protected SimplifiedBicycle()
    {
        ModelName = string.Empty; // filled in by subclass constructor
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year;
        BuildStatus = ManufacturingStatus.Specified;
    }
    public void Build()
    {
        Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
        BuildStatus = ManufacturingStatus.FrameManufactured;
        PrintBuildStatus();

        if (Suspension != SuspensionTypes.Hardtail)
        {
            Console.WriteLine($"Mounting the {Suspension.ToString()} suspension.");
            BuildStatus = ManufacturingStatus.SuspensionMounted;
            PrintBuildStatus();
        }

        Console.WriteLine("{0} {1} Bicycle serial number {2} manufacturing complete!", Year, ModelName, SerialNumber);
        BuildStatus = ManufacturingStatus.Complete;
        PrintBuildStatus();
    }

    private void PrintBuildStatus()
    {
        Console.WriteLine($"Status: {BuildStatus.ToString()}");
    }
}