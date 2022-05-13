using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactoryExample;

public class RecumbentBicycleFactory : IBicycleFactory
{
    public IFrame CreateBicycleFrame()
    {
        return new RecumbentFrame();
    }

    public IHandlebars CreateBicycleHandleBars()
    {
        return new RecumbentHandlebars();
    }
}