namespace BicycleBuilderExample;

public interface IBicycleBuilder
{
    public void Reset();
    public void BuildFrame();
    public void BuildHandleBars();

    public void BuildSeat();
    public void BuildSuspension();
    public void BuildDriveTrain();
    public void BuildBrakes();

    public IBicycleProduct GetProduct();
}