namespace BumbleBikesLibrary.PaintableBicycle;

public abstract class PaintableBicycle : IPaintableBicycle
{
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public BicycleGeometries Geometry { get; set; }
    public SuspensionTypes Suspension { get; set; }
    public ManufacturingStatus BuildStatus { get; set; }
    public IPaintJob PaintJob { get; set; }

    protected PaintableBicycle(IPaintJob paintJob)
    {
        ModelName = string.Empty; // will be filled in subclass constructor
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year;
        BuildStatus = ManufacturingStatus.Specified;
        PaintJob = paintJob;
    }

    public void Build()
    {
        Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
        BuildStatus = ManufacturingStatus.FrameManufactured;
        PrintBuildStatus();
        
        Console.WriteLine($"Painting the frame {PaintJob.Name}");
        PaintJob.ApplyPrimer();
        PaintJob.ApplyPaint();
        PaintJob.ApplyTopCoat();
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
            $"Your bicycle is a {PaintJob.Name} {ModelName}, with a {Suspension.ToString()} suspension and a(n) {Geometry.ToString()} geometry.";
    }

}