using BumbleBikesLibrary;

namespace DecoratorExample;

public class DocumentedBicycle : AbstractBicycleDecorator
{
    private IDocumentor _documentor;

    public DocumentedBicycle(IBicycle bicycle, ManualPrinter printer) : base(bicycle)
    {
        _documentor = printer;
    }
    
    public override void Build()
    {
        UndecoratedBicycle.Build();
        _documentor.PrintManual();
    }
}