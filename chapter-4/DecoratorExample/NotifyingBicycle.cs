using BumbleBikesLibrary;

namespace DecoratorExample;

public class NotifyingBicycle : AbstractBicycleDecorator
{
    private readonly INotifier _notifier;

    public NotifyingBicycle(IBicycle bicycle, INotifier notifier) : base(bicycle)
    {
        _notifier = notifier;
    }
    public override void Build()
    {
        UndecoratedBicycle.Build();
        _notifier.Notify();
    }
}