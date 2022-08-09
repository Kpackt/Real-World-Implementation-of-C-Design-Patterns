namespace WheelchairProject;

using WheelchairComponents;
public abstract class UnpoweredChair : Wheelchair
{
    public MechanicalWheel RightWheel { get; set; }
    public MechanicalWheel LeftWheel { get; set; }
    public CasterAssembly Casters { get; set; }

    // protected UnpoweredChair(MechanicalWheel rightWheel, MechanicalWheel leftWheel, CasterAssembly casters)
    // {
    //     RightWheel = rightWheel;
    //     LeftWheel = leftWheel;
    //     Casters = casters;
    // }
}