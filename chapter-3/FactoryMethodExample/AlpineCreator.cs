using BumbleBikesLibrary;

namespace FactoryMethodExample;

public class AlpineCreator : BicycleCreator
{
    public override IBicycle CreateProduct(string modelName)
    {
        return modelName.ToLower() switch
        {
            "palo duro canyon ranger" => new MountainBike(),
            "galveston cruiser" => new Cruiser(),
            _ => throw new Exception("Invalid bicycle model")
        };
    }
}