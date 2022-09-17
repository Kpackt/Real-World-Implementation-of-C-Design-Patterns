namespace WheelchairProject.WheelchairComponents.Seats;

public abstract class WheelchairSeat : WheelchairComponent
{
    protected float BackHeight { get; set; }
    protected float Width { get; set; }
    protected float SeatThickness { get; set; }
    
    // Seat is a leaf so it doesn't need a FixComposite() method.
}