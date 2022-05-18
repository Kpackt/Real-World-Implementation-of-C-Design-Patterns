namespace BridgeExample;

public enum PrimerColors { Gray, White, Black }
public enum PrimerTypes {Epoxy, Urethan, Polyester, AcidEtch, Enamel, Lacquer, MoistureCure}
public interface IPrimer
{
    public string ManufacturerStockKeepingUnit { get; set; }
    public PrimerTypes Type { get; set; }
    public bool IsLowVoc { get; set; }
    
}