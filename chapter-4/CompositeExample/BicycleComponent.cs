namespace CompositeExample;

public abstract class BicycleComponent
{
    private float Weight { get; set; }
    private float Cost { get; set; }

    public IList<BicycleComponent> SubComponents;

    protected BicycleComponent(float weight, float cost)
    {
        SubComponents = new List<BicycleComponent>();
        Weight = weight;
        Cost = cost;
    }

    public void DisplayWeight()
    {
        if (SubComponents.Count <= 0) return;
        foreach (var component in SubComponents)
        {
            Console.WriteLine(component.GetType().Name + " weighs " + component.Weight);
            component.DisplayWeight();
        }
    }

    public void DisplayCost()
    {
        if (SubComponents.Count <= 0) return;
        foreach (var component in SubComponents)
        {
            Console.WriteLine(component.GetType().Name + " costs $" + component.Cost + " USD");
            component.DisplayCost();
        }
    }
}

 