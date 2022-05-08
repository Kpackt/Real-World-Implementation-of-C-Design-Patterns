namespace BumbleBikesLibrary.BicycleComponents.Drivetrain;

public class RoadDrivetrain : AbstractDrivetrain
{
    public RoadDrivetrain()
    {
        Shifter = ShifterTypes.Paddle;
        CrankLength = 6.72f;
        ChainLinkCount = 126;
        FrontCassetteCogs = 3;
        RearCassetteCogs = 8;
        IsEnclosed = false;
    }
}