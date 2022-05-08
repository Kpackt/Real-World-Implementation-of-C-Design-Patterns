using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactoryExample;

public class RoadBicycleFactory : IBicycleFactory
{
    public IFrame CreateBicycleFrame()
    {
        return new RoadBikeFrame();
    }

    public IHandlebars CreateBicycleHandleBars()
    {
        return new RoadBikeHandlebars();
    }
}