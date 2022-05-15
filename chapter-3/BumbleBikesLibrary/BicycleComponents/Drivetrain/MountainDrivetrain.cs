namespace BumbleBikesLibrary.BicycleComponents.Drivetrain;

public class MountainDrivetrain : AbstractDrivetrain
{
    public MountainDrivetrain()
    {
        Shifter = ShifterTypes.Trigger;
        CrankLength = 5.92f;
        ChainLinkCount = 126;
        FrontCassetteCogs = 2;
        RearCassetteCogs = 9;
        IsEnclosed = false;
    }
}