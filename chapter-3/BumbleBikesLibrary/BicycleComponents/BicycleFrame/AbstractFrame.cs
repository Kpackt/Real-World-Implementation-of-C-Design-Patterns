// This is actually a copy of the bicycle class presented early in the chapter.
// In the real world it would have been refactored as soon as Phoebe realized the bicycle object 
// was going to be more complicated when she worked on implementing the builder pattern.  If I
// had changed the name organically in the process, the earlier part of the chapter's code wouldn't
// match the text, so the class itself is copied and renamed.  It's not DRY but it is more pedagogical.

namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame;

public abstract class AbstractFrame : IFrame
{
    protected AbstractFrame()
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