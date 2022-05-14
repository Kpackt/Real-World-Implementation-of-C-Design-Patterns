using BumbleBikesLibrary;
using DecoratorExample;

var regularRoadBike = new RoadBike();  //no decorators.

var bikeWithBell = new BellDecorator(regularRoadBike);
bikeWithBell.Ring();

var bikeWithHeadLights = new IntegratedHeadLightDecorator(regularRoadBike)
{
    LightOn = true,
    PercentBatteryCharge = 95
};

bikeWithHeadLights.LightOn = true;
bikeWithHeadLights.PercentBatteryCharge = 99;