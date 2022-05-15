namespace CompositeExample;

public abstract class BicycleComponent
{
    public float Weight { get; set; }
    public float Cost { get; set; }

    private List<BicycleComponent> _subComponents;

    protected BicycleComponent(float weight, float cost)
    {
        _subComponents = new List<BicycleComponent>();
    }

    protected void AddSubcomponent(BicycleComponent component)
    {
        _subComponents.Add(component);
    }
}