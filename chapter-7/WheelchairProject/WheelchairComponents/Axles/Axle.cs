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

    // The axle contains the wheels for the purposes of the composite pattern
    // FixComposite() clears out the list and adds the wheels whenever you change
    // them via the accessor methods.  The composite pattern is maintained
    // automatically.
    private void FixComposite()
    {
        Subcomponents.Clear();
        Subcomponents.Add(_leftWheel);
        Subcomponents.Add(_rightWheel);
    }
}