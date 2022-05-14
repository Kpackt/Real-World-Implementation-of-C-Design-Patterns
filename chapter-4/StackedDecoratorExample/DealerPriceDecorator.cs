using BumbleBikesLibrary;

namespace StackedDecoratorExample;

public class DealerPriceDecorator : CostDecorator
{
    public DealerPriceDecorator(IBicycle bicycle) : base(bicycle) 
    {
        
    }

    public override decimal GetCost()
    {
        // Bumble Bikes sells to dealers with a 12.5% markup
        // var costOfGoodsSold = GetCost();
        // return costOfGoodsSold + (costOfGoodsSold * 0.125m);
        return UndecoratedBicycle.ModelName switch
        {
            "Hillcrest" => 1231.09m,
            "Palo Duro Canyon Ranger" => 1832.09m,
            "Galveston Cruiser" => 425.38m,
            "Big Bend" => 739.32m,
            _ => 0m
        };
    }
}