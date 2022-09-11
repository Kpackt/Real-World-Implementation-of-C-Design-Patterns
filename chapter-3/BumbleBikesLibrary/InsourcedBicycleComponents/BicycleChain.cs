using BumbleBikesLibrary.BicycleComponents;

namespace BumbleBikesLibrary.InsourcedBicycleComponents;

public class BicycleChain : IBicycleComponent
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }

    public BicycleChain()
    {
        Name = "BB 9 Speed Chain w/ Master Link";
        Weight = 336f;
        Cost = 12.75f;
    }
}