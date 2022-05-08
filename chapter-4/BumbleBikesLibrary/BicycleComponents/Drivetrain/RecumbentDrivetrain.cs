namespace BumbleBikesLibrary.BicycleComponents.Drivetrain;

public class RecumbentDrivetrain : AbstractDrivetrain
{
    public RecumbentDrivetrain()
    {
        Shifter = ShifterTypes.Paddle;
        CrankLength = 8.13f;
        ChainLinkCount = 421;
        FrontCassetteCogs = 3;
        RearCassetteCogs = 7;
        IsEnclosed = false;
    }
}