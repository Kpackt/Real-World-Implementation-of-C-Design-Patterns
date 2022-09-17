using WheelchairProject.WheelchairComponents;

namespace WheelchairProject;

public class UnpoweredChair : Wheelchair
{
    public WheelchairComponent RightWheel { get; set; }
    public WheelchairComponent LeftWheel { get; set; }
    public WheelchairComponent Casters { get; set; }
}