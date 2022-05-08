namespace BumbleBikesLibrary.BicycleComponents.Handlebars;

public class RecumbentHandlebars : AbstractHandlebars
{
    public RecumbentHandlebars()
    {
        // units are imperial   
        Length = 11.5f;
        Diameter = 1.0f;
        IsDropped = false;
        RiseAngle = 2.5f;
    }
}