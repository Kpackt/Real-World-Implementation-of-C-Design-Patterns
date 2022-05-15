namespace BumbleBikesLibrary;

public class MountainBike : Bicycle
{
    public MountainBike()
    {
        ModelName = "Palo Duro Canyon Ranger";
        Suspension = SuspensionTypes.Full;
        Color = BicyclePaintColors.Black;
        Geometry = BicycleGeometries.Upright;
    }
}