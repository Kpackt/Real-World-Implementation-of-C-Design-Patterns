namespace DecoratorExample;
using BumbleBikesLibrary;
public class BellDecorator : AccessorizedBicycleDecorator
{
    public BellDecorator(IBicycle undecoratedBicycle) : base(undecoratedBicycle)
    {
        
    }
    public void Ring()
    {
        Console.WriteLine("BLING BLING!");
    }
}