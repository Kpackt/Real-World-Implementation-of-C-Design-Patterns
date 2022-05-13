using BumbleBikesLibrary;

namespace FactoryMethodExample;

public class DallasCreator : BicycleCreator
{
    public override IBicycle CreateProduct(string modelName)
    {
        return modelName.ToLower() switch
        {
            "hillcrest" => new RoadBike(),
            "big bend" => new Recumbent(),
            _ => throw new Exception("Invalid bicycle model")
        };
    }
}