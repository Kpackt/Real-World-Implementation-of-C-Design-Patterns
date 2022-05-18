using BumbleBikesLibrary;

namespace BridgeExample;

public abstract class PaintedBicycle : IBicycle
{
    protected readonly IBicycle UndecoratedBicycle;
    private IPaintJob _paintJob;

    protected PaintedBicycle(IBicycle bicycle, IPaintJob paintJob)
    {
        UndecoratedBicycle = bicycle;
        _paintJob = paintJob;
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
    [ObsoleteAttribute("BicyclePaintColors is deprecated.  Use the PaintJob to control the color.", true)]
    public BicyclePaintColors Color
    {
        get => UndecoratedBicycle.Color;
        set => UndecoratedBicycle.Color = value;
    }

    public IPaintJob PaintJob { get; set; }


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