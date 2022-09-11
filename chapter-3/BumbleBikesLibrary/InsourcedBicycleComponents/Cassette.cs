using BumbleBikesLibrary.BicycleComponents;

namespace BumbleBikesLibrary.InsourcedBicycleComponents;

public class Cassette : IBicycleComponent
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }

    public Cassette()
    {
        Name = "BB Cassette 9 Speed 12-32 Teeth";
        Weight = 250f;
        Cost = 18.53f;
    }
}