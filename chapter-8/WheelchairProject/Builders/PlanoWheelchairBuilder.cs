using System.Dynamic;
using WheelchairProject.WheelchairComponents;
using WheelchairProject.WheelchairComponents.Axles;
using WheelchairProject.WheelchairComponents.Casters;
using WheelchairProject.WheelchairComponents.Frames;
using WheelchairProject.WheelchairComponents.Seats;
using WheelchairProject.WheelchairComponents.Wheels;

namespace WheelchairProject.Builders;

public class PlanoWheelchairBuilder : IWheelchairBuilder
{
    private PlanoWheelchair _wheelchair;

    public PlanoWheelchairBuilder()
    {
        Reset();
        
    }
    
    public void Reset()
    {
        _wheelchair = new PlanoWheelchair();
        
    }

    public void BuildFrame()
    {
        _wheelchair.Frame = new PlanoWheelchairFrame();
    }
    

    public void BuildAxleAssembly()
    {
        var leftWheel = new StandardWheel();
        var rightWheel = new StandardWheel();
        var axle = new StandardAxle(leftWheel, rightWheel);
        _wheelchair.Frame.Axle = axle;
    }

    public void BuildCasterAssembly()
    {
        var planoCasterWheel = new CasterWheel();
        var casterAssembly = new PlanoCasterAssembly(planoCasterWheel);
        _wheelchair.Frame.LeftCaster = casterAssembly;
        _wheelchair.Frame.RightCaster = casterAssembly;
    }

    public void BuildSeat()
    {
        _wheelchair.Seat = new PlanoSeat();
        
    }

    //shouldn't need this anymore
    public void BuildComposite()
    {
       _wheelchair.Subcomponents.Clear();
       _wheelchair.Subcomponents.Add(_wheelchair.Seat);
       
       _wheelchair.Frame.Subcomponents.Clear();
       
    }

    public void BuildFramePainter()
    {
        throw new NotImplementedException();
    }

    public Wheelchair GetProduct()
    {
        return _wheelchair;
    }
}