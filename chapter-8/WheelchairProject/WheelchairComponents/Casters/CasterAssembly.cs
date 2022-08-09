using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject.WheelchairComponents.Casters;

public abstract class CasterAssembly : WheelchairComponent
{
    public MechanicalWheel Wheel { get; set; }
    public string MountingType { get; set; }
    public float LoadCapacity { get; set; }
}