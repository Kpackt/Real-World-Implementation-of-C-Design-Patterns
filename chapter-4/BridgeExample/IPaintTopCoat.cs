namespace BridgeExample;

public enum PaintTopCoatTypes { TopCoatClear, GlamorClear, TurboClear, HigherSolidClear }
public interface IPaintTopCoat
{
    public PaintTopCoatTypes Type { get; set; }
}