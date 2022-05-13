using System.Globalization;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BumbleBikesLibrary.BicycleComponents;

public class AbstractHandlebars : IHandlebars
{
    public float Length { get; set; }
    public float Diameter { get; set; }
    public bool IsDropped { get; set; }
    public float RiseAngle { get; set; }

    public override string ToString()
    {
        var isDroppedText = "dropped";
        if (IsDropped) isDroppedText = "non-dropped";
        return
            $"Your {isDroppedText} handlebars are {Length.ToString(CultureInfo.InvariantCulture)} wide, {Diameter.ToString(CultureInfo.InvariantCulture)} in diameter, with a rise angle of {RiseAngle.ToString(CultureInfo.InvariantCulture)}";
    }
}