using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactoryExample;

public class MountainBicycleFactory : IBicycleFactory
{
    public IFrame CreateBicycleFrame()
    {
        return new MountainBikeFrame();
    }

    public IHandlebars CreateBicycleHandleBars()
    {
        return new MountainBikeHandlebars();
    }
}