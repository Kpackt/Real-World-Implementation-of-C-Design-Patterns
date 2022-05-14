using BumbleBikesLibrary;

namespace DecoratorExample;

public class AccessorizedBicycle : IBicycle
{
    private IBicycle UndecoratedBicycle { get; set; }
    private List<IAccessory> Accessories { get; set; }
    
    public AccessorizedBicycle(IBicycle bicycle, List<IAccessory> accessories)
    {
        UndecoratedBicycle = bicycle;
        Accessories = accessories;
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

    
    public void Build()
    {
        UndecoratedBicycle.Build();
    }
}