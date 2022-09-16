using WheelchairProject.WheelchairComponents;

namespace WheelchairProject;

public class UnpoweredChair : Wheelchair
{
    protected WheelchairComponent RightWheel { get; set; }
    protected WheelchairComponent LeftWheel { get; set; }
    protected WheelchairComponent Casters { get; set; }

    protected UnpoweredChair(WheelchairComponent rightWheel, WheelchairComponent leftWheel, WheelchairComponent casters)
    {
        RightWheel = rightWheel;
        LeftWheel = leftWheel;
        Casters = casters;
    }

}