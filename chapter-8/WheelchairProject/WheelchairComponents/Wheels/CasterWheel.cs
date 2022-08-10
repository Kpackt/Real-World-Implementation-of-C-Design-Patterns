namespace WheelchairProject.WheelchairComponents.Wheels;

public class CasterWheel : MechanicalWheel
{
    public CasterWheel()
    {
        Price = 5.21f;
        Weight = 0.753f;
        Radius = 6f;
        IsPneumatic = true;
        SpokeCount = 24;
    }
}