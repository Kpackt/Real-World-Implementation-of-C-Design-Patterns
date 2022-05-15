namespace BumbleBikesLibrary.BicycleComponents.Suspensions;

public class FullSuspension : AbstractSuspension
{
    public FullSuspension()
    {
        HasFrontShock = true;
        HasRearShock = true;
    }
}