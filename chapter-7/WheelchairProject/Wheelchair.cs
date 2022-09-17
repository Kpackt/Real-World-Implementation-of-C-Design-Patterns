using WheelchairProject.Painters;
using WheelchairProject.WheelchairComponents.Frames;
using WheelchairProject.WheelchairComponents.Seats;

namespace WheelchairProject;
using WheelchairComponents;
public abstract class Wheelchair : WheelchairComponent, IManufacturable
{
    private WheelchairSeat _seat;
    private WheelchairFrame _frame;
    public string ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }

    public WheelchairSeat Seat
    {
        get => _seat;
        set
        {
            _seat = value;
            FixComposite();
        }
    }

    public WheelchairFrame Frame
    {
        get => _frame;
        set
        {
            _frame = value;
            FixComposite();
        }
    }
    public IFramePainter FramePainter { get; set; } // doesn't need to be in the composite
    
    // FixComposite() clears out the list and adds the wheels whenever you change
    // them via the accessor methods.  The composite pattern is maintained
    // automatically.
    private void FixComposite()
    {
        Subcomponents.Clear();
        Subcomponents.Add(_frame);
        Subcomponents.Add(_seat);
    }
    public string? BuildStatus { get; set; }
    
    protected Wheelchair()
    {
        ModelName = string.Empty; // will be filled in subclass constructor
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year; 
    }
}