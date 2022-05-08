using BumbleBikesLibrary;

namespace SimpleFactoryExample;

public class SimpleBicycleFactory
{
    public Bicycle CreateBicycle(string bicycleType)
    {
        Bicycle bikeToBuild;
        switch (bicycleType)
        {
            case "mountainbike":
                bikeToBuild = new MountainBike();
                break;
            case "cruiser":
                bikeToBuild = new Cruiser();
                break;
            case "recumbent":
                bikeToBuild = new Recumbent();
                break;
            case "roadbike":
                bikeToBuild = new RoadBike();
                break;
            default:
                throw new Exception("Unknown bicycle type: " + bicycleType);
        }

        return bikeToBuild;
    }
}