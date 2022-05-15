namespace FacadeExample;

public class GrabbingApi
{
    public void Grab()
    {
        Console.WriteLine("The grabber is grabbing!");
    }

    public void SetLocation(int x, int y)
    {
        Console.WriteLine("Moving to {0}, {1}", x, y);
    }

    // In the UML diagram in the text it says SomeOtherSubSystemOperation99()
    // So imagine there are 99 exposed operations here and we don't care about any of them.  We only care about
    // SetLocation and the Grab methods.
    public void SomeOtherSubSystemOperation99()
    {
        Console.WriteLine("YAGNI!");  // this never gets called on purpose.
    }
}