namespace BumbleBikesLibrary.BicycleComponents.Seats;

public interface ISeat
{
    public SeatSaddleTypes SaddleType { get; set; }
    public float PaddingThickness { get; set; }
    public int SpringCount { get; set; }
}