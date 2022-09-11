using BumbleBikesLibrary.BicycleComponents;

namespace BumbleBikesLibrary.InsourcedBicycleComponents;

public class BottomBracket : IBicycleComponent
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }

    public BottomBracket()
    {
        Name = "BB Bottom Bracket 68 x 122.5mm Spindle Square Taper JIS 50mm Chainline";
        Weight = 284.835f;
        Cost = 11.51f;
    }
}