namespace DecoratorExample;

using BumbleBikesLibrary;

public abstract class AccessorizedBicycleDecorator : IBicycle
{
    private IBicycle UndecoratedBicycle;
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public BicycleGeometries Geometry { get; set; }
    public BicyclePaintColors Color { get; set; }
    public SuspensionTypes Suspension { get; set; }
    public ManufacturingStatus BuildStatus { get; set; }

    public AccessorizedBicycleDecorator()
    {
        
    }
    public void Build()
    {
        throw new NotImplementedException();
    }

    
}