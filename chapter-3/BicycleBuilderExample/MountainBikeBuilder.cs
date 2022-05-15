using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Brakes;
using BumbleBikesLibrary.BicycleComponents.Drivetrain;
using BumbleBikesLibrary.BicycleComponents.Handlebars;
using BumbleBikesLibrary.BicycleComponents.Seats;
using BumbleBikesLibrary.BicycleComponents.Suspensions;

namespace BicycleBuilderExample;

public class MountainBikeBuilder : IBicycleBuilder
{
    private BicycleProduct _bicycle;

    public MountainBikeBuilder()
    {
        Reset(); // the IDE hates this but it is DRY
    }

    public void Reset()
    {
        _bicycle = new BicycleProduct();
    }

    public void BuildFrame()
    {
        _bicycle.Frame = new MountainBikeFrame();
    }

    public void BuildHandleBars()
    {
        _bicycle.Handlebars = new MountainBikeHandlebars();
    }

    public void BuildSeat()
    {
        _bicycle.Seat = new GenericSeat();
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = new FullSuspension();
    }

    public void BuildDriveTrain()
    {
        _bicycle.Drivetrain = new MountainDrivetrain();
    }

    public void BuildBrakes()
    {
        _bicycle.Brakes = new DiscBrakes();
    }

    public IBicycleProduct GetProduct()
    {
        BuildFrame();
        BuildHandleBars();
        BuildSeat();
        BuildSuspension();
        BuildDriveTrain();
        BuildBrakes();
        return _bicycle;
    }
}