using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Brakes;

public enum BicycleBrakeTypes
{
    Coaster,
    Caliper,
    Disc
}

public abstract class AbstractBrakes : IBrakes
{
    public BicycleBrakeTypes BrakeType { get; set; }

    public override string ToString()
    {
        return $"Your brakes are {BrakeType.ToString(CultureInfo.InvariantCulture)}";
    }
}