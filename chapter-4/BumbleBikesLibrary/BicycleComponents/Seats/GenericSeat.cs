namespace BumbleBikesLibrary.BicycleComponents.Seats;

public class GenericSeat : AbstractSeat
{
    public GenericSeat()
    {
        PaddingThickness = 0.1f;
        SaddleType = SeatSaddleTypes.ModeratelyWaved;
        SpringCount = 0;
    }
}