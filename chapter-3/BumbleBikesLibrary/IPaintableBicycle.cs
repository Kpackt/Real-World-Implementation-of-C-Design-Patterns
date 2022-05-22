namespace BumbleBikesLibrary;

// same as IBicycle but with paint color enum removed
// see the chapter on the Bridge pattern
public interface IPaintableBicycle
{
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public BicycleGeometries Geometry { get; set; }
    public SuspensionTypes Suspension { get; set; }
    public ManufacturingStatus BuildStatus { get; set; }

    public void Build();
}