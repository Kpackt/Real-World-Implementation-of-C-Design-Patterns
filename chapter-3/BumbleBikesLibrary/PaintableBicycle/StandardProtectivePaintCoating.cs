namespace BumbleBikesLibrary.PaintableBicycle;

public class StandardProtectivePaintCoating : IPaintTopCoat
{
    public string Name { get; set; }
    public PaintTopCoatTypes Type { get; set; }

    public StandardProtectivePaintCoating()
    {
        Name = "Standard Protective Paint Coating";
        Type = PaintTopCoatTypes.GlamorClear;  // gives a very glossy finish and blocks UV
    }
}