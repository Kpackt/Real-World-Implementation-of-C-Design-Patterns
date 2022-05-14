using BumbleBikesLibrary;

namespace StackedDecoratorExample;

public class ManufacturersSuggestedRetailPriceDecorator : CostDecorator
{
    public ManufacturersSuggestedRetailPriceDecorator(IBicycle bicycle) : base(bicycle) 
    {
        
    }

    public override decimal GetCost()
    {
        return 0.0m;
    }
}