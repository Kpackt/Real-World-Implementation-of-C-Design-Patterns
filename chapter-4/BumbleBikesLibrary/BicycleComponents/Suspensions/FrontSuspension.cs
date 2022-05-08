namespace BumbleBikesLibrary.BicycleComponents.Suspensions;

public class FrontSuspension : AbstractSuspension
{
    public FrontSuspension()
    {
        HasFrontShock = true;
        HasRearShock = false;
    }
}