using BumbleBikesLibrary;

namespace SimpleFactoryExample;

public class BicycleFoundry
{
    public BicycleFoundry(SimpleBicycleFactory factory)
    {
        Factory = factory;
    }

    private SimpleBicycleFactory Factory { get; }


    public Bicycle ManufactureBicycle(string type)
    {
        var bike = Factory.CreateBicycle(type);
        bike.Build();
        return bike;
    }
}