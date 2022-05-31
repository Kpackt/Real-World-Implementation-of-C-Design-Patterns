namespace BumbleBikesLibrary.PaintableBicycle.CommonPaintJobs;

public class RedPaintJob: IPaintJob
{
    public string Name { get; set; }
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }

    public RedPaintJob()
    {
        Name = "Red River Shootout";  // named for the football rivalry between Oklahoma and Texas
        Cyan = 0;
        Magenta = 80;
        Yellow = 80;
        Black = 40;
        Primer = new StandardGrayPrimer();
        TopCoat = new StandardProtectivePaintCoating();
    }
    
    public void ApplyPrimer()
    {
        Console.WriteLine($"Applying the Primer: {Primer.ManufacturerStockKeepingUnit}");
    }

    public void ApplyPaint()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Applying {Name.ToUpper()} paint job.");
        Console.ResetColor();
    }

    public void ApplyTopCoat()
    {
        Console.WriteLine($"Applying protective paint finish: {TopCoat.Name}");
    }
    
}