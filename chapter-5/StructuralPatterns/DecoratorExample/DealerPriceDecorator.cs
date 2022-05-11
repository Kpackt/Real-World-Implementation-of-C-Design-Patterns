using BumbleBikesLibrary;

namespace DecoratorExample;

public class DealerPriceDecorator : CostDecorator
{
    public DealerPriceDecorator(IBicycle bicycle) : base(bicycle)
    {
        
    }

    public Decimal GetCost()
    {
        return 0m;
    }
}