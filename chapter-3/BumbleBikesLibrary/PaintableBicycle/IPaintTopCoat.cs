namespace BumbleBikesLibrary.PaintableBicycle;
public enum PaintTopCoatTypes { TopCoatClear, GlamorClear, TurboClear, HigherSolidClear }

public interface IPaintTopCoat
{
    public string Name { get; set; }
    public PaintTopCoatTypes Type { get; set; }

}