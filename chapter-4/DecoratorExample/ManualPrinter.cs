namespace DecoratorExample;

public class ManualPrinter : IDocumentor
{
    public void PrintManual()
    {
        Console.WriteLine("The manual is printing!");
    }
}