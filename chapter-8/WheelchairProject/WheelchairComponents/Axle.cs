namespace WheelchairProject.WheelchairComponents;

public abstract class Axle : WheelchairComponent 
{
    protected float Radius { get; set; }
    protected float Length { get; set; }
    public MechanicalWheel LeftWheel { get; set; }
    public MechanicalWheel RightWheel { get; set; }
}