using BumbleBikesLibrary;

namespace DecoratorExample;

public abstract class AbstractBicycleDecorator : IBicycle 
{
    protected readonly IBicycle UndecoratedBicycle;

    protected AbstractBicycleDecorator(IBicycle bicycle)
    {
        UndecoratedBicycle = bicycle;
    }
    public string ModelName
    {
        get => UndecoratedBicycle.ModelName;
        set => UndecoratedBicycle.ModelName = value;
    }
    public int Year => UndecoratedBicycle.Year;
    public string SerialNumber => UndecoratedBicycle.SerialNumber;
    public BicycleGeometries Geometry
    {
        get => UndecoratedBicycle.Geometry;
        set => UndecoratedBicycle.Geometry = value;
    }
    public BicyclePaintColors Color
    {
        get => UndecoratedBicycle.Color; 
        set => UndecoratedBicycle.Color = value; 
    }
    public SuspensionTypes Suspension { 
        get => UndecoratedBicycle.Suspension;
        set => UndecoratedBicycle.Suspension = value;
    }
    public ManufacturingStatus BuildStatus { 
        get => UndecoratedBicycle.BuildStatus;
        set => UndecoratedBicycle.BuildStatus = value;
    }

    public abstract void Build();

}