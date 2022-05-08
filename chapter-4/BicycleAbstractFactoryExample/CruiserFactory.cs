using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactoryExample;

public class CruiserFactory : IBicycleFactory
{
    public IFrame CreateBicycleFrame()
    {
        return new CruiserFrame();
    }

    public IHandlebars CreateBicycleHandleBars()
    {
        return new CruiserHandlebars();
    }
}