namespace WheelchairProject.WheelchairComponents;

public class ElectricMotor
{
    protected float InputVoltage { get; set; }
    protected float Torque { get; set; }
    protected bool IsPoweredOn { get; set; }
}