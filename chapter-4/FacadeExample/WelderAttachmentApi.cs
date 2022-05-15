namespace FacadeExample;

public class WelderAttachmentApi
{
    public void Weld()
    {
        Console.WriteLine("Welding...");
        Console.WriteLine("Weld complete!");
    }

    public void MoveTo(int x, int y, int z)
    {
        Console.WriteLine("Moving to {0}, {1}, {2}", x, y, z);
        Console.WriteLine("I'm there!");
    }
    
    // In the UML diagram in the text it says SomeOtherSubSystemOperation300()
    // So imagine there are 300 exposed operations here and we don't care about any of them.  We only care about
    // MoveTo and the Weld methods.
    public void SomeOtherSubSystemOperation300()
    {
        Console.WriteLine("YAGNI!");  // this never gets called on purpose.
    }
}