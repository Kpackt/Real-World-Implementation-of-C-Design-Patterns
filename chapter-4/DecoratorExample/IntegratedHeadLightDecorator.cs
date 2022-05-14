namespace DecoratorExample;
using BumbleBikesLibrary;
public class IntegratedHeadLightDecorator : AccessorizedBicycleDecorator
{
    public IntegratedHeadLightDecorator(IBicycle undecoratedBicycle) : base(undecoratedBicycle)
    {
        
    }
    public bool LightOn { get; set; }
    public int PercentBatteryCharge { get; set; }
}