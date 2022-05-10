namespace DecoratorExample;

public class IntegratedHeadLightDecorator : AccessorizedBicycleDecorator
{
    public bool LightOn { get; set; }
    public int PercentBatteryCharge { get; set; }
}