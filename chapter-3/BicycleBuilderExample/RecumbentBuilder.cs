using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Brakes;
using BumbleBikesLibrary.BicycleComponents.Drivetrain;
using BumbleBikesLibrary.BicycleComponents.Handlebars;
using BumbleBikesLibrary.BicycleComponents.Seats;
using BumbleBikesLibrary.BicycleComponents.Suspensions;

namespace BicycleBuilderExample;

public class RecumbentBuilder : IBicycleBuilder
{
    private IBicycleProduct _bicycle;

    public RecumbentBuilder()
    {
        _bicycle = new BicycleProduct();
    }

    public void Reset()
    {
        _bicycle = new BicycleProduct();
    }

    public void BuildFrame()
    {
        _bicycle.Frame = new RecumbentFrame();
    }

    public void BuildHandleBars()
    {
        _bicycle.Handlebars = new RecumbentHandlebars();
    }

    public void BuildSeat()
    {
        _bicycle.Seat = new RecumbentSeat();
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = new FrontSuspension();
    }

    public void BuildDriveTrain()
    {
        _bicycle.Drivetrain = new RecumbentDrivetrain();
    }

    public void BuildBrakes()
    {
        _bicycle.Brakes = new DiscBrakes();
    }

    public IBicycleProduct GetProduct()
    {
        return _bicycle;
    }
}