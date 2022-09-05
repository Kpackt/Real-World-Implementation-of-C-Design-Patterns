namespace ObserverExample;

public class ExFedObserver : ILogisticsObserver
{
    public void SchedulePickup()
    {
        Console.WriteLine("ExFed has been notified that a shipment is ready for pick up.");
    }
}