using BumbleBikesLibrary;

namespace BridgeExample;

public class AbstractPaintJob : IPaintJob
{
    public AbstractPaintJob(BicyclePaintColors stockColor)
    {
        switch (stockColor)
        {
            case BicyclePaintColors.Black:
                Cyan = 0;
                Magenta = 0;
                Yellow = 0;
                Black = 100;
                break;
            case BicyclePaintColors.Blue:
                Cyan = 88;
                Magenta = 77;
                Yellow = 0;
                Black = 0;
                break;
            case BicyclePaintColors.Red:
                Cyan = 0;
                Magenta = 100;
                Yellow = 100;
                Black = 0;
                break;
            case BicyclePaintColors.White:
                Cyan = 0;
                Magenta = 0;
                Yellow = 0;
                Black = 0;
                break;
            default:
                throw new IndexOutOfRangeException();
        }
    }
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }
    public string ColorName { get; set; }
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }
    public void ApplyPrimer()
    {
        throw new NotImplementedException();
    }

    public void ApplyTopCoat()
    {
        throw new NotImplementedException();
    }
}