namespace DecoratorExample;

public class ManualPrinter : IDocumentor
{
    public void PrintManual()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;  // so it stands out
        Console.WriteLine("The manual is printing!");
        Console.ResetColor();
    }
}