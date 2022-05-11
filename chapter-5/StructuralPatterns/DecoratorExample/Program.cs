
using BumbleBikesLibrary;
using DecoratorExample;

var regularRoadBike = new RoadBike();  //no decorations

var bikeWithBell = new BellDecorator(regularRoadBike);
bikeWithBell.Ring();

IntegratedHeadLightDecorator bikeWithHeadLights = new IntegratedHeadLightDecorator(regularRoadBike)
{
    LightOn = true,
    PercentBatteryCharge = 95
};

var totallyTrickedOutBike = new BellDecorator(new IntegratedHeadLightDecorator(regularRoadBike));
totallyTrickedOutBike.Ring();

