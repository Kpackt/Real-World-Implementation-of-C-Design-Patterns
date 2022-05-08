namespace BumbleBikesLibrary;

public enum BicycleGeometries
{
    Upright,
    Recumbent
}

public enum BicyclePaintColors
{
    Black,
    Red,
    White,
    Blue
}

public enum ManufacturingStatus
{
    Specified,
    FrameManufactured,
    Painted,
    SuspensionMounted,
    Complete
}

public enum SuspensionTypes
{
    Full,
    Front,
    Hardtail
}

public abstract class Bicycle : IBicycle
{
    protected Bicycle()
    {
        ModelName = string.Empty; // will be filled in subclass constructor
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year;
        BuildStatus = ManufacturingStatus.Specified;
    }

    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public BicyclePaintColors Color { get; set; }
    public BicycleGeometries Geometry { get; set; }
    public SuspensionTypes Suspension { get; set; }
    public ManufacturingStatus BuildStatus { get; set; }

    public void Build()
    {
        Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
        BuildStatus = ManufacturingStatus.FrameManufactured;
        PrintBuildStatus();

        Console.WriteLine($"Painting the frame {Color.ToString()}");
        BuildStatus = ManufacturingStatus.Painted;
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

    public override string ToString()
    {
        return
            $"Your bicycle is a {Color.ToString()} {ModelName}, with a {Suspension.ToString()} suspension and a(n) {Geometry.ToString()} geometry.";
    }
}