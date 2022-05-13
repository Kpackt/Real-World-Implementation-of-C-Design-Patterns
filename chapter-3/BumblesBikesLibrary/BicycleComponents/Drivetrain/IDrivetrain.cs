namespace BumbleBikesLibrary.BicycleComponents.Drivetrain;

public interface IDrivetrain
{
    public float CrankLength { get; set; }
    public int FrontCassetteCogs { get; set; }
    public int RearCassetteCogs { get; set; }
    public float ChainLinkCount { get; set; }
    public ShifterTypes Shifter { get; set; }
    public bool IsEnclosed { get; set; }
}