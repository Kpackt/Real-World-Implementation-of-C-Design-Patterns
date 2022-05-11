namespace DecoratorExample;
using BumbleBikesLibrary;
public abstract class CostDecorator
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

    public CostDecorator(IBicycle undecoratedBicycle)
    {
        UndecoratedBicycle = undecoratedBicycle;
    }
    
    public void Build()
    {
        UndecoratedBicycle.Build();
    }

    public Decimal GetCost()
    {
        switch (UndecoratedBicycle.ModelName)
        {
            case "Hillcrest":
                return 1231.09m;
                break;
            case "Palo Duro Canyon Ranger":
                return 1832.09m;
                break;
            case "Galveston Cruiser":
                return 425.38m;
                break;
            case "Big Bend":
                return 739.32m;
                break;
            default:
                return 0m;
        }
    }
}