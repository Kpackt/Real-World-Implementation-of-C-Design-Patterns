using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject.WheelchairComponents.Casters;

public abstract class CasterAssembly : WheelchairComponent
{
    private MechanicalWheel _wheel;

    protected MechanicalWheel Wheel
    {
        get => _wheel;
        set
        {
            _wheel = value;
            Subcomponents.Clear();
            Subcomponents.Add(value);
        }
    }
    protected string Swivel { get; set; }
    public string MountingType { get; set; }
    public float LoadCapacity { get; set; }
    
    // caster assembly is a leaf so it doesn't need a FixComposite() method.
}