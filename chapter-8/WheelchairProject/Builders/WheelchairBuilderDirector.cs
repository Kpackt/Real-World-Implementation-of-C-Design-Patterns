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
        _builder.BuildAxleAssembly();
        _builder.BuildCasterAssembly();
        // _builder.BuildFramePainter();

        return _builder.GetProduct();
    }
}