namespace WheelchairProject.WheelchairComponents;

public abstract class WheelchairComponent
{
    protected float Weight { get; set; }
    protected float Price { get; set; }
    protected List<WheelchairComponent> Subcomponents { get; set; }

    protected WheelchairComponent()
    {
        Subcomponents = new List<WheelchairComponent>();
        Weight = 0.0f;
        Price = 0.0f;
    }

    public void DisplayWeight()
    {
        if (!Subcomponents.Any()) return;
        foreach (var component in Subcomponents)
        {
            Console.WriteLine(component.GetType().Name + " weighs " + component.Weight);
            component.DisplayWeight();
        }
    }

    public void DisplayCost()
    {
        if (!Subcomponents.Any()) return;
        foreach (var component in Subcomponents)
        {
            Console.WriteLine(component.GetType().Name + " costs $" + component.Price + " USD");
            component.DisplayCost();
        }
    }
}