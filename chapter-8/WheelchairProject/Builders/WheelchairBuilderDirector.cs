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
        throw new NotImplementedException();
    }
}