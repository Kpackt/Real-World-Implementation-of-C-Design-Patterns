using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject.WheelchairComponents.Casters;

public abstract class CasterAssembly : WheelchairComponent
{
    private MechanicalWheel _wheel;

    public MechanicalWheel Wheel
    {
        get => _wheel;
        set
        {
            _wheel = value;
            Subcomponents.Clear();
            Subcomponents.Add(value);
        }
    }

    public string MountingType { get; set; }
    public float LoadCapacity { get; set; }
}