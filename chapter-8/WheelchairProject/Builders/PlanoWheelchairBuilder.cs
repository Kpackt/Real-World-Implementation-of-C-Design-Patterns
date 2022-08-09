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
        var axle = new StandardAxle();
        var leftWheel = new StandardWheel();
        var rightWheel = new StandardWheel();

        axle.LeftWheel = leftWheel;
        axle.RightWheel = rightWheel;

        _wheelchair.Frame.Axle = axle;
    }

    public void BuildCasterAssembly()
    {
        var leftCaster = new PlanoCasterAssembly();
        leftCaster
    }

    public void BuildSeat()
    {
        _wheelchair.Seat = new PlanoSeat();
        
    }

    public void BuildComposite()
    {
       _wheelchair.Subcomponents.Clear();
       _wheelchair.Subcomponents.Add(_wheelchair.Seat);
       
       _wheelchair.Frame.Subcomponents.Clear();
       _wheelchair.Frame.Subcomponents.Add(_wheelchair.Axle);
       _wheelchair.Frame.Subcomponents.Add(_wheelchair.Casters);
    }

    public void BuildFramePainter()
    {
        throw new NotImplementedException();
    }

    public Wheelchair GetProduct()
    {
        return new PlanoWheelchair();
    }
}