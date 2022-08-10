using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject.WheelchairComponents.Axles;

public abstract class Axle : WheelchairComponent 
{
    private MechanicalWheel _leftWheel;
    private MechanicalWheel _rightWheel;
    protected float Radius { get; set; }
    protected float Length { get; set; }

    public MechanicalWheel LeftWheel
    {
        get => _leftWheel;
        set
        {
            _leftWheel = value;
            FixComposite();
        }
    }

    public MechanicalWheel RightWheel
    {
        get => _rightWheel;
        set
        {
            _rightWheel = value;
           FixComposite();
        }
    }

    private void FixComposite()
    {
        Subcomponents.Clear();
        Subcomponents.Add(_leftWheel);
        Subcomponents.Add(_rightWheel);
    }
}