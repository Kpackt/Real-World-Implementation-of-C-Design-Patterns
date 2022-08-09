namespace WheelchairProject.Builders;

public class WheelchairBuilderDirector
{
    private IWheelchairBuilder _builder;

    public WheelchairBuilderDirector(IWheelchairBuilder builder)
    {
        _builder = builder;
    }

    public Wheelchair Build()
    {
        _builder.BuildSeat();
        _builder.BuildFrame();
        _builder.BuildWheels();
        _builder.BuildFramePainter();
        _builder.BuildComposite();

        return _builder.GetProduct();
    }
}