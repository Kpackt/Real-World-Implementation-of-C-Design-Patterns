namespace BumbleBikesLibrary.PaintableBicycle;

public class PaintableCruiser : PaintableBicycle
{
    public PaintableCruiser(IPaintJob paintJob) : base(paintJob)
    {
        ModelName = "Galveston Cruiser";
        Suspension = SuspensionTypes.Hardtail;
        Geometry = BicycleGeometries.Upright;
    }
}