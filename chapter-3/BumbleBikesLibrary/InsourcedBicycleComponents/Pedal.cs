using BumbleBikesLibrary.BicycleComponents;

namespace BumbleBikesLibrary.InsourcedBicycleComponents;

public class Pedal : IBicycleComponent
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }

    public Pedal()
    {
        Name = "BB Aluminum Allow Pedal w/ Anti-Slip Studs";
        Weight = 430f;
        Cost = 13.74f;
    }
}