using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Brakes;
using BumbleBikesLibrary.BicycleComponents.Drivetrain;
using BumbleBikesLibrary.BicycleComponents.Handlebars;
using BumbleBikesLibrary.BicycleComponents.Seats;
using BumbleBikesLibrary.BicycleComponents.Suspensions;

namespace BicycleBuilderExample;

public class CruiserBicycleBuilder : IBicycleBuilder
{
    private IBicycleProduct _bicycle;

    public CruiserBicycleBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _bicycle = new BicycleProduct();
    }

    public void BuildFrame()
    {
        _bicycle.Frame = new CruiserFrame();
    }

    public void BuildHandleBars()
    {
        _bicycle.Handlebars = new CruiserHandlebars();
    }

    public void BuildSeat()
    {
        _bicycle.Seat = new CruiserSeat();
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = new HardTailSuspension();
    }

    public void BuildDriveTrain()
    {
        _bicycle.Drivetrain = new CruiserDrivetrain();
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