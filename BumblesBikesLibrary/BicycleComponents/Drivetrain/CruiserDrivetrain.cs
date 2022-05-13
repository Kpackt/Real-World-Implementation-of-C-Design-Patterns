namespace BumbleBikesLibrary.BicycleComponents.Drivetrain;

public class CruiserDrivetrain : AbstractDrivetrain
{
    public CruiserDrivetrain()
    {
        Shifter = ShifterTypes.Twist;
        CrankLength = 6.72f;
        ChainLinkCount = 126;
        FrontCassetteCogs = 1;
        RearCassetteCogs = 9;
        IsEnclosed = true;
    }
}