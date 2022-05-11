namespace DecoratorExample;

using BumbleBikesLibrary;

public abstract class AccessorizedBicycleDecorator : IBicycle
{
    protected IBicycle UndecoratedBicycle;
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

    public AccessorizedBicycleDecorator(IBicycle undecoratedBicycle)
    {
        UndecoratedBicycle = undecoratedBicycle;
    }
    public void Build()
    {
        UndecoratedBicycle.Build();
    }

    
}