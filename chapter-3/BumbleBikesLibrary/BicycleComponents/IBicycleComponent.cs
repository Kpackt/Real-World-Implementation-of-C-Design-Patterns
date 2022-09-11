namespace BumbleBikesLibrary.BicycleComponents;

public interface IBicycleComponent
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }
}