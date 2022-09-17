namespace WheelchairProject.WheelchairComponents.Wheels;

public abstract class MechanicalWheel : WheelchairComponent
{
    protected float Radius { get; set; }
    protected int SpokeCount { get; set; }
    protected bool IsPneumatic { get; set; }
    
    // wheel is a leaf component so it doesn't need a FixComposite() method.
}