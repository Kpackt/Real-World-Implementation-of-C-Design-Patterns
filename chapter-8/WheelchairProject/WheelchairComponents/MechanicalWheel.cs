namespace WheelchairProject.WheelchairComponents;

public abstract class MechanicalWheel : WheelchairComponent
{
    protected float Radius { get; set; }
    protected int SpokeCount { get; set; }
    protected bool IsPneumatic { get; set; }
}