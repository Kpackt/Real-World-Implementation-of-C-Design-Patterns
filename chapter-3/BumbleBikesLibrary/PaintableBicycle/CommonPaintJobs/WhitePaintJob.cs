namespace BumbleBikesLibrary.PaintableBicycle.CommonPaintJobs;

public class WhitePaintJob: IPaintJob
{
    public string Name { get; set; }
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }

    public WhitePaintJob()
    {
        Name = "Alpine White";  // Named for the city of Alpine even though it never snows there.
        Cyan = 0;
        Magenta = 0;
        Yellow = 0;
        Black = 0;
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