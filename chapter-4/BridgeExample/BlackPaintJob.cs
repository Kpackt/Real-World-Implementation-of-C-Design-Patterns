using BumbleBikesLibrary.PaintableBicycle;

namespace BridgeExample;

public class BlackPaintJob : IPaintJob
{
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }

    public BlackPaintJob()
    {
        Cyan = 0;
        Magenta = 0;
        Yellow = 0;
        Black = 100;
        Primer = new StandardGrayPrimer();
        TopCoat = new StandardProtectivePaintCoating();
    }
    
    public void ApplyPrimer()
    {
        Console.WriteLine("Applying the Primer: " + Primer.ManufacturerStockKeepingUnit);
    }

    public void ApplyPaint()
    {
        Console.WriteLine("Applying a black paint job.");
        Console.WriteLine("Finally, one we can see in the book.");
    }

    public void ApplyTopCoat()
    {
        Console.WriteLine("Applying protective paint finish: " + TopCoat.Name);
    }
}