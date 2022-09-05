namespace ObserverExample;

public class LogisticsSubject
{
    private readonly List<ILogisticsObserver> _logisticsObservers;

    public LogisticsSubject()
    {
        _logisticsObservers = new List<ILogisticsObserver>();
    }

    public void Attach(ILogisticsObserver observer)
    {
        _logisticsObservers.Add(observer);
        PrintObserversCount();
    }

    public void Detach(ILogisticsObserver observer)
    {
        _logisticsObservers.Remove(observer);
        PrintObserversCount();
    }

    private void PrintObserversCount()
    {
        switch (_logisticsObservers.Count)
        {
            case < 1:
                Console.WriteLine("There are no observers.");
                break;
            case 1:
                Console.WriteLine("There is 1 observer.");
                break;
            default:
                Console.WriteLine("There are " + _logisticsObservers.Count + " observers.");
                break;
        }
    }
    public void NotifyPickupAvailable()
    {
        foreach (var subscriber in _logisticsObservers)
        {
            subscriber.SchedulePickup();
        }
    }
}