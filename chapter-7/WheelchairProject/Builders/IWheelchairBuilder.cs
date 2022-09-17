namespace WheelchairProject.Builders;

public interface IWheelchairBuilder
{
    public void Reset();
    public void BuildFrame();
    public void BuildWheels();
    public void BuildAxleAssembly();
    public void BuildCasterAssembly();
    public void BuildSeat();
    public void BuildFramePainter();
    
    public Wheelchair GetProduct();
}