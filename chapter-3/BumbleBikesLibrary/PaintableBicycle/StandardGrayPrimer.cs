namespace BumbleBikesLibrary.PaintableBicycle;

public class StandardGrayPrimer : IPrimer
{
    public string ManufacturerStockKeepingUnit { get; set; }
    public PrimerTypes Type { get; set; }
    public bool IsLowVoc { get; set; }

    public StandardGrayPrimer()
    {
        Type = PrimerTypes.Epoxy;
        IsLowVoc = false;
        ManufacturerStockKeepingUnit = "PRIMER-GRAY-001";
    }
}