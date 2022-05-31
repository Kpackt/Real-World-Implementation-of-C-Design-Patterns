namespace BumbleBikesLibrary.PaintableBicycle;

public class PaintableMountainBike : PaintableBicycle
{
    public PaintableMountainBike(IPaintJob paintJob) : base(paintJob)
    {
        ModelName = "Palo Duro Canyon Ranger";
        Suspension = SuspensionTypes.Full;
        Geometry = BicycleGeometries.Upright;
    }
}