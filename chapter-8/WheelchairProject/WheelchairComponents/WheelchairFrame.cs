namespace WheelchairProject.WheelchairComponents;

public abstract class WheelchairFrame : WheelchairComponent
{
    public Axle Axle { get; set; }
    public CasterAssembly Casters { get; set; }
}