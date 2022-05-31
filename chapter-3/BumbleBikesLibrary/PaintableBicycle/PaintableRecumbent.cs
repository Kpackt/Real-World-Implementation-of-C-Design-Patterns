namespace BumbleBikesLibrary.PaintableBicycle;

public class PaintableRecumbent : PaintableBicycle
{
    public PaintableRecumbent(IPaintJob paintJob) : base(paintJob)
    {
        ModelName = "Big Bend";
        Suspension = SuspensionTypes.Front;
        Geometry = BicycleGeometries.Recumbent;
    }
}