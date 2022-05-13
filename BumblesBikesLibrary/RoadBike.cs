namespace BumbleBikesLibrary;

public class RoadBike : Bicycle
{
    public RoadBike()
    {
        ModelName = "Hillcrest";
        Suspension = SuspensionTypes.Hardtail;
        Color = BicyclePaintColors.Blue;
        Geometry = BicycleGeometries.Upright;
    }
}