namespace WheelchairProject.WheelchairComponents.Wheels;

public class StandardWheel : MechanicalWheel
{
    public StandardWheel()
    {
        Price = 11.34f;
        Weight = 1.3f;
        Radius = 16f;
        IsPneumatic = true;
        SpokeCount = 48;
    }
}