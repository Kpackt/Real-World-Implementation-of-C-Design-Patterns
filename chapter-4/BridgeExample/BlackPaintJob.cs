using BumbleBikesLibrary.PaintableBicycle;

namespace BridgeExample;

public class BlackPaintJob : IPaintJob
{
    public string Name { get; set; }
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }

    public BlackPaintJob()
    {
        Name = "Black Gap Step";  // named for the famous Black Gap Step at Big Bend
        Cyan = 0;
        Magenta = 0;
        Yellow = 0;
        Black = 100;
        Primer = new StandardGrayPrimer();
        TopCoat = new StandardProtectivePaintCoating();
    }
    
    public void ApplyPrimer()
    {
        Console.WriteLine($"Applying the Primer: {Primer.ManufacturerStockKeepingUnit}");
    }

    public void ApplyPaint()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"Applying {Name.ToUpper()} paint job.");
        Console.ResetColor();
    }

    public void ApplyTopCoat()
    {
        Console.WriteLine($"Applying protective paint finish: {TopCoat.Name}");
    }
    
}