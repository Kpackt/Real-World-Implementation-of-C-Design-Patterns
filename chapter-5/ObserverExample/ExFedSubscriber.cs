namespace ObserverExample;

public class ExFedSubscriber : ILogisticSubscriber
{
    public void SchedulePickup()
    {
        Console.WriteLine("ExFed has been notified that a shipment is ready for pick up.");
    }
}