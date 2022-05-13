using BumbleBikesLibrary;

namespace FactoryMethodExample;

public abstract class BicycleCreator
{
    public abstract IBicycle CreateProduct(string modelName);
}