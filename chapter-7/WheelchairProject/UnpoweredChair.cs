using WheelchairProject.WheelchairComponents;
using WheelchairProject.WheelchairComponents.Casters;
using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject;

public class UnpoweredChair : Wheelchair
{
    public MechanicalWheel RightWheel { get; set; }
    public MechanicalWheel LeftWheel { get; set; }
    public CasterAssembly Casters { get; set; }
}