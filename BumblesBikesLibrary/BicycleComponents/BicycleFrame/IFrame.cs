namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame;

public interface IFrame
{
    // not just for HTML anymore!  I should have named this IBicycleFrame, but then I couldn't make the IFrame joke.
    // This is actually a copy of the IBicycle interface presented early in the chapter.
    // In the real world it would have been refactored as soon as Phoebe realized the bicycle object 
    // was going to be more complicated when she worked on implementing the builder pattern.  If I
    // had changed the name organically in the process, the earlier part of the chapter's code wouldn't
    // match the text, so it's copied.  It's not DRY but it is more pedagogical.

    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public BicycleGeometries Geometry { get; set; }
    public BicyclePaintColors Color { get; set; }
    public SuspensionTypes Suspension { get; set; }
    public ManufacturingStatus BuildStatus { get; set; }

    public void Build();
}