namespace BumbleBikesLibrary.PaintableBicycle;

public class PaintableRoadBike : PaintableBicycle
{
    public PaintableRoadBike(IPaintJob paintJob) : base(paintJob)
    {
        ModelName = "Hillcrest";
        Suspension = SuspensionTypes.Hardtail;
        Geometry = BicycleGeometries.Upright;
    }
}