namespace DecoratorExample;

public class MaterialsInventoryNotifier : INotifier
{
    public void Notify()
    {
        Console.WriteLine("The materials inventory control system has been notified regarding the manufacture of this bicycle.");
    }
}