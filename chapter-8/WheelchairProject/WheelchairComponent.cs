namespace WheelchairProject;

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

    protected float DisplayWeight()
    {
        throw new NotImplementedException();
    }

    protected float DisplayCost()
    {
        throw new NotImplementedException();
    }
    
}