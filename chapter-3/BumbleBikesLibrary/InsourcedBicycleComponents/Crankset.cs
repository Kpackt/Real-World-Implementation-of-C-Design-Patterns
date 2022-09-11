using BumbleBikesLibrary.BicycleComponents;

namespace BumbleBikesLibrary.InsourcedBicycleComponents;

public class Crankset : IBicycleComponent
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }

    public Crankset()
    {
        Name = "BB Crankset";
        Weight = 1180f;
        Cost = 17.99f;
    }
}