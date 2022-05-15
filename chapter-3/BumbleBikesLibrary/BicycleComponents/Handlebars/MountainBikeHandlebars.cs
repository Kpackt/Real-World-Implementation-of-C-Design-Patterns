namespace BumbleBikesLibrary.BicycleComponents.Handlebars;

public class MountainBikeHandlebars : AbstractHandlebars
{
    public MountainBikeHandlebars()
    {
        // units are imperial   
        Length = 24.5f;
        Diameter = 1.0f;
        IsDropped = false;
        RiseAngle = 0.0f;
    }
}