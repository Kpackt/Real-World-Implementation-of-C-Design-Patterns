namespace WheelchairProject;

using WheelchairComponents;
public abstract class UnpoweredChair : Wheelchair
{
    protected MechanicalWheel RightWheel { get; set; }
    protected MechanicalWheel LeftWheel { get; set; }
    protected CasterAssembly Casters { get; set; }

    // protected UnpoweredChair(MechanicalWheel rightWheel, MechanicalWheel leftWheel, CasterAssembly casters)
    // {
    //     RightWheel = rightWheel;
    //     LeftWheel = leftWheel;
    //     Casters = casters;
    // }
}