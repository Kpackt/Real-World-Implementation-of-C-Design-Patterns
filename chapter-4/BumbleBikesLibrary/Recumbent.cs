namespace BumbleBikesLibrary;

public class Recumbent : Bicycle
{
    public Recumbent()
    {
        ModelName = "Big Bend";
        Suspension = SuspensionTypes.Front;
        Color = BicyclePaintColors.White;
        Geometry = BicycleGeometries.Recumbent;
    }
}