using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactoryExample;

public interface IBicycleFactory
{
    public IFrame CreateBicycleFrame();
    public IHandlebars CreateBicycleHandleBars();
}