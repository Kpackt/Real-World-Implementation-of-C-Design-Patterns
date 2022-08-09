namespace WheelchairProject.Builders;

public interface IWheelchairBuilder
{
    public void Reset();
    public void BuildFrame();
    public void BuildWheels();
    public void BuildSeat();
    public void BuildComposite();
    public void BuildFramePainter();
}