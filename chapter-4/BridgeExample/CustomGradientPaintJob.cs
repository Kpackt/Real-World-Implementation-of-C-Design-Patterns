using BumbleBikesLibrary;

namespace BridgeExample;
using BumbleBikesLibrary.PaintableBicycle;
public class CustomGradientPaintJob : IPaintJob
{
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }
    
    // do do a gradient we need a starting color value and an ending value.  we'll use
    // the normal cmyk colors for the starting color and add a set for the ending color
    public int EndCyan { get; set; }
    public int EndMagenta { get; set; }
    public int EndYellow { get; set; }
    public int EndBlack { get; set; }
    
    public CustomGradientPaintJob()
    {
        Primer = new StandardGrayPrimer();
        TopCoat = new StandardProtectivePaintCoating();
        
        // starting color is a nice yellow
        Cyan = 6;
        Magenta = 0;
        Yellow = 95;
        Black = 0;
        
        // end color is teal
        EndCyan = 85;
        EndMagenta = 25;
        EndYellow = 50;
        EndBlack = 5;
    }
    public void ApplyPrimer()
    {
        Console.WriteLine("Applying the Primer: " + Primer.ManufacturerStockKeepingUnit);
    }

    public void ApplyPaint()
    {
        Console.WriteLine("Applying custom paint job.");
        Console.WriteLine("Isn't it a shame this book is printed in black and white?");
        Console.WriteLine("Trust us, it is truly beautiful!");
    }
    public void ApplyTopCoat()
    {
        Console.WriteLine("Applying protective paint finish: " + TopCoat.Name);
    }
}