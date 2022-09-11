using BumbleBikesLibrary.BicycleComponents;

namespace BumbleBikesLibrary.InsourcedBicycleComponents;

public class Spindle : IBicycleComponent
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }

    public Spindle()
    {
        Name = "BB Spindle 15cm";
        Weight = 111.989f;
        Cost = 4.85f;
    }
}