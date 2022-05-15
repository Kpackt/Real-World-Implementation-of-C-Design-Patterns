using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Brakes;
using BumbleBikesLibrary.BicycleComponents.Drivetrain;
using BumbleBikesLibrary.BicycleComponents.Handlebars;
using BumbleBikesLibrary.BicycleComponents.Seats;
using BumbleBikesLibrary.BicycleComponents.Suspensions;

namespace BicycleBuilderExample;

public class RoadBikeBuilder : IBicycleBuilder
{
    private BicycleProduct _bicycle;

    public RoadBikeBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _bicycle = new BicycleProduct();
    }

    public void BuildFrame()
    {
        _bicycle.Frame = new RoadBikeFrame();
    }

    public void BuildHandleBars()
    {
        _bicycle.Handlebars = new RoadBikeHandlebars();
    }

    public void BuildSeat()
    {
        _bicycle.Seat = new GenericSeat();
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = new HardTailSuspension();
    }

    public void BuildDriveTrain()
    {
        _bicycle.Drivetrain = new RoadDrivetrain();
    }

    public void BuildBrakes()
    {
        _bicycle.Brakes = new CaliperBrakes();
    }

    public IBicycleProduct GetProduct()
    {
        return _bicycle;
    }
}