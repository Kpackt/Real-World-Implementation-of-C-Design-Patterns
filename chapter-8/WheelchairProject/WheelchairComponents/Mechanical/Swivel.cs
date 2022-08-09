using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject.WheelchairComponents.Mechanical;

public class Swivel
{
    public string MountingTYpe { get; set; }
    public float LoadCapacity { get; set; }
    public MechanicalWheel Wheel { get; set; }

    public Swivel()
    {
        LoadCapacity = 300.0f;
        MountingTYpe = "STEM";
    }
}