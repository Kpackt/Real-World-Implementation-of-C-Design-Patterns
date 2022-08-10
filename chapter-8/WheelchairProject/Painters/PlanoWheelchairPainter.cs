namespace WheelchairProject.Painters;

public class PlanoWheelchairPainter : IFramePainter
{
    public string PaintColorName { get; set; }
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    
    public void MixPaint()
    {
        Console.WriteLine("Mixing in Cyan: " + Cyan.ToString() );
        Console.WriteLine("Mixing in Magenta: " + Magenta.ToString() );
        Console.WriteLine("Mixing in Yellow: " + Yellow.ToString() );
        Console.WriteLine("Mixing in Black: " + Black.ToString() );
        Console.WriteLine("Mixing complete!  The color is: " + PaintColorName);
    }

    public void PaintFrame()
    {
        Console.WriteLine("Applying " + PaintColorName);
    }

    public void ApplyTopCoat()
    {
        Console.WriteLine("Applying topcoat");
    }
}