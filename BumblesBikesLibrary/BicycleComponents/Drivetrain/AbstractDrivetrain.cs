using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Drivetrain;

public enum ShifterTypes
{
    Paddle,
    Trigger,
    Twist
}

public class AbstractDrivetrain : IDrivetrain
{
    public float CrankLength { get; set; }
    public int FrontCassetteCogs { get; set; }
    public int RearCassetteCogs { get; set; }
    public float ChainLinkCount { get; set; }
    public ShifterTypes Shifter { get; set; }
    public bool IsEnclosed { get; set; }

    public override string ToString()
    {
        return
            $"Your group set consists of a {CrankLength.ToString(CultureInfo.InvariantCulture)} inch crank, {FrontCassetteCogs.ToString(CultureInfo.InvariantCulture)} cost in the front cassette, {RearCassetteCogs.ToString(CultureInfo.InvariantCulture)} cogs in the rear cassette, and a chain with {ChainLinkCount.ToString(CultureInfo.InvariantCulture)} links in the chain and a {Shifter.ToString()} type shifter.";
    }
}