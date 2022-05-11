using BumbleBikesLibrary;

namespace DecoratorExample;

public class CostOfGoodsSoldDecorator : CostDecorator
{
    public CostOfGoodsSoldDecorator(IBicycle bicycle) : base(bicycle)
    {
        
    }

    public Decimal GetCost()
    {
        switch (UndecoratedBicycle.ModelName)
        {
            case "Hillcrest":
                return 1231.09m;
                break;
            case "Palo Duro Canyon Ranger":
                return 1832.09m;
                break;
            case "Galveston Cruiser":
                return 425.38m;
                break;
            case "Big Bend":
                return 739.32m;
                break;
            default:
                return 0m;
        }
    }
}