namespace WheelchairProject.WheelchairComponents.Electrical;

public abstract class Battery : WheelchairComponent
{
    protected float Voltage { get; set; }
    protected float AmpHours { get; set; }
}