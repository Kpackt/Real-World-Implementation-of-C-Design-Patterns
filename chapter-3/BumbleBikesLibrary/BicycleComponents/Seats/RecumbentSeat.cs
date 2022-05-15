namespace BumbleBikesLibrary.BicycleComponents.Seats;

public class RecumbentSeat : AbstractSeat
{
    public RecumbentSeat()
    {
        SaddleType = SeatSaddleTypes.LazyBoyRecliner;
        SpringCount = 6;
        PaddingThickness = 0.5f;
    }
}