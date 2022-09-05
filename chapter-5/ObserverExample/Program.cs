// Let's ship some bikes!

using ObserverExample;
using BumbleBikesLibrary;

var logisticsSubject = new LogisticsSubject();

var exFed = new ExFedObserver();
logisticsSubject.Attach(exFed);

// Now let's make some bikes.  Each time we have 10, we'll send a notification.
var pickupOrder = new List<Bicycle>();

for (var i = 0; i < 99; i++)
{
    var bike = new MountainBike();
    
    // it takes a bit to make it, but not too long
    Thread.Sleep(3000);
    Console.WriteLine(bike.ToString());
    pickupOrder.Add(bike);
    
    if (pickupOrder.Count > 9)
    {
        logisticsSubject.NotifyPickupAvailable();
        
        // now pretend pickup was instantaneous
        pickupOrder.Clear();
    }
}

// done making bikes for today.

logisticsSubject.Detach(exFed);