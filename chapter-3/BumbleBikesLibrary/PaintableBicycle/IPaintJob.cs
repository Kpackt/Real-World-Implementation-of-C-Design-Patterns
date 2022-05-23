namespace BumbleBikesLibrary.PaintableBicycle;

public interface IPaintJob
{
    public string Name { get; set; }
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }

    public void ApplyPrimer();
    public void ApplyPaint();
    public void ApplyTopCoat();

}