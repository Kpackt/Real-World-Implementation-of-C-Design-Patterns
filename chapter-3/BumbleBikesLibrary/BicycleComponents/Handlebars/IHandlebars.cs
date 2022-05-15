namespace BumbleBikesLibrary.BicycleComponents.Handlebars;

public interface IHandlebars
{
    public float Length { get; set; }
    public float Diameter { get; set; }
    public bool IsDropped { get; set; }
    public float RiseAngle { get; set; }
}