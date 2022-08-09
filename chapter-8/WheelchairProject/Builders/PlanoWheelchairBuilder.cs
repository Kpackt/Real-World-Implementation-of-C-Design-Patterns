namespace WheelchairProject.Builders;

public class PlanoWheelchairBuilder : IWheelchairBuilder
{
    private PlanoWheelchair _wheelchair;
    
    public void Reset()
    {
        _wheelchair = new PlanoWheelchair();
    }

    public void BuildFrame()
    {
        throw new NotImplementedException();
    }

    public void BuildWheels()
    {
        throw new NotImplementedException();
    }

    public void BuildSeat()
    {
        // the seat is a leaf node so just make one ad add it as a component
        
        throw new NotImplementedException();
    }

    public void BuildComposite()
    {
        throw new NotImplementedException();
    }

    public void BuildFramePainter()
    {
        throw new NotImplementedException();
    }

    public PlanoWheelchair GetProduct()
    {
        // the wheelchair is built as a composite of wheelchair components. 
        // they must be assembled in a particular order.
        
        
        throw new NotImplementedException();
    }
}