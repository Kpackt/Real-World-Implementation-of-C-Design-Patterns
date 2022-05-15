namespace CompositeExample;

// The pedal is the leaf since it contains no other components.
public class Pedal : BicycleComponent
{
    public Pedal(float weight, float cost) : base(weight, cost)
    {
    }
}