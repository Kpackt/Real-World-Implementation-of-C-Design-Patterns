namespace BumbleBikesLibrary.BicycleComponents.Seats;

public class CruiserSeat : AbstractSeat
{
    public CruiserSeat()
    {
        PaddingThickness = 0.4f; // very cushy!
        SaddleType = SeatSaddleTypes.Curved;
        SpringCount = 3;
    }
}