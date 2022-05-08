namespace BumbleBikesLibrary.BicycleComponents.Handlebars;

public class RoadBikeHandlebars : AbstractHandlebars
{
    public RoadBikeHandlebars()
    {
        // units are imperial   
        Length = 24.5f;
        Diameter = 1.0f;
        IsDropped = true;
        RiseAngle = 3.93f;
    }
}