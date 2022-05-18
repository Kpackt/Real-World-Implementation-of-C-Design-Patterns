namespace BridgeExample;

public interface IPaintJob
{
    public IPrimer Primer { get; set; }
    public IPaintTopCoat TopCoat { get; set; }
    public string ColorName { get; set; }
    public int Cyan { get; set; }
    public int Magenta { get; set; }
    public int Yellow { get; set; }
    public int Black { get; set; }

    public void ApplyPrimer();
    public void ApplyTopCoat();
}