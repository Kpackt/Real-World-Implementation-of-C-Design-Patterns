namespace DecoratorExample;

public class BellDecorator : AccessorizedBicycleDecorator
{
    public void Ring()
    {
        Console.WriteLine("BLING BLING!");
    }
}