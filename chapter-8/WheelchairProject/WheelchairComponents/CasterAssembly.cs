namespace WheelchairProject.WheelchairComponents;

public abstract class CasterAssembly : WheelchairComponent
{
    protected MechanicalWheel Wheel { get; set; }
    // I didn't model out a swivel to keep things simple for the book.  Taken to its logical conclusion
    // wew might wind up with a hundred classes here.
    protected string Swivel { get; set; }  
}