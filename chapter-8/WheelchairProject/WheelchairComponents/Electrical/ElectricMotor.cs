namespace WheelchairProject.WheelchairComponents.Electrical;

public class ElectricMotor
{
    protected float InputVoltage { get; set; }
    protected float Torque { get; set; }
    protected bool IsPoweredOn { get; set; }
}