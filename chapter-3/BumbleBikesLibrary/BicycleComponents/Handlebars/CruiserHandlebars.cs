namespace BumbleBikesLibrary.BicycleComponents.Handlebars;

public class CruiserHandlebars : AbstractHandlebars
{
    public CruiserHandlebars()
    {
        // units are imperial   
        Length = 32.6f;
        Diameter = 1.0f;
        IsDropped = false;
        RiseAngle = 6.35f;
    }
}