namespace WheelchairProject;

using WheelchairComponents;
public abstract class UnpoweredChair : Wheelchair
{
    
    public Axle Axle { get; set; }
    public CasterAssembly Casters { get; set; }
    
}