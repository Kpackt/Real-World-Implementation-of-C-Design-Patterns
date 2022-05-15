using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Seats;

public enum SeatSaddleTypes
{
    Flat,
    Waved,
    ModeratelyWaved,
    Curved,
    LazyBoyRecliner
}

public class AbstractSeat : ISeat
{
    public SeatSaddleTypes SaddleType { get; set; }
    public float PaddingThickness { get; set; }
    public int SpringCount { get; set; }

    public override string ToString()
    {
        return
            $"Your seat has a {SaddleType} type saddle with a padding thickness of {PaddingThickness.ToString(CultureInfo.InvariantCulture)}, and {SpringCount.ToString(CultureInfo.InvariantCulture)} springs.";
    }
}