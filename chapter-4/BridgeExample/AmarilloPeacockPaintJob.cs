using BumbleBikesLibrary.PaintableBicycle;

namespace BridgeExample;

public class AmarilloPeacockPaintJob : CustomGradientPaintJob
{
    public AmarilloPeacockPaintJob()
    {
        Name = "Amarillo Peacock";  // Amarillo is a city in the Texas panhandle.  Amarillo is Spanish for "yellow".
        Primer = new StandardGrayPrimer();
        TopCoat = new StandardProtectivePaintCoating();
        
        // Starting color is a nice yellow, hence the "amarillo" in the name.
        Cyan = 6;
        Magenta = 0;
        Yellow = 95;
        Black = 0;
        
        // End color is teal like a peacock.
        EndCyan = 85;
        EndMagenta = 25;
        EndYellow = 50;
        EndBlack = 5;
    }
    
    public override void ApplyPaint()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"Applying custom paint job {Name.ToUpper()}");
        Console.ResetColor();
    }
}