using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject.WheelchairComponents.Casters;

public class PlanoCasterAssembly : CasterAssembly
{
    public PlanoCasterAssembly(MechanicalWheel wheel)
    {
        LoadCapacity = 300.0f;
        MountingType = "STEM";
        Weight = 0.443f;
        Price = 4.32f;
        Wheel = wheel;
    }
        
}