using System.Numerics;

namespace FacadeExample;

public class BuffingApi
{
    /*
     * This is a simulated API.  Imagine a very complicated API perhaps with a lot of exposed methods we don't need
     * or want.  We'll use a facade to hide the complexity.
     */

    public void Buff()
    {
        Console.WriteLine("Buffing...");
    }

    // A quaternion is a horribly complex mathematical structure.  There's no reason you'd know that unless
    // you're a Unity developer.  It represents four dimensions including 3 dimensions in space (X, Y, Z) and
    // a rotational vector expressed as an Euler angle normally called W.  An Euler angle describes the
    // orientation of a rigid body with respect to a fixed coordinate system.  I used it because while I am not
    // a robotics expert, I have done a lot with Unity and it seemed plausible to my story to use it here
    // to specify the position for a robotic arm.  My real aim is to have several APIs that express positioning
    // robotics using different structures to make this appear complex.  All suppositions that I am a mathematician
    // are abjectly false.
    
    public void Position(Quaternion position)
    {
        Console.WriteLine("Moving the robot arm to {0}, {1}, {2} at angle {3} ", position.X, position.Y, position.Z, position.W);
    }
    
    // In the UML diagram in the text it says SomeOtherSubSystemOperation400()
    // So imagine there are 400 exposed operations here and we don't care about any of them.  We only care about
    // Position and the Buff methods.

    public void SomeOtherSubSystemOperation400()
    {
        Console.WriteLine("YAGNI!");  // this never gets called on purpose.
    }
}