// A dealer is ordering a bunch of bikes.  To keep it simple we'll just do 5 bikes.

using System.Net.Mail;
using BumbleBikesLibrary.PaintableBicycle;
using BumbleBikesLibrary.PaintableBicycle.CommonPaintJobs;
using IteratorExample;

// here's a list of orders over which we'll iterate
var orders = new OrdersCollection();

var dealership = new Customer
{
    FirstName = "John",
    LastName = "Galt",
    CompanyName = "Atlas Cycling",
    Email = new MailAddress("johngalt@whois.com"),
    ShippingAddress = "123 Singleton Drive",
    ShippingCity = "Dallas",
    ShippingState = "Tx",
    ShippingZipCode = "75248"
};

var amarilloPeacockPaintjob = new AmarilloPeacockPaintJob();
var bicycle0 = new PaintableMountainBike(amarilloPeacockPaintjob);

var order0 = new BicycleOrder(dealership, bicycle0);
orders.AddOrder(order0);

var turquoisePaintJob = new BluePaintJob();
var bicycle1 = new PaintableCruiser(turquoisePaintJob);
var order1 = new BicycleOrder(dealership, bicycle1);
orders.AddOrder(order1);

var whitePaintJob = new WhitePaintJob();
var bicycle2 = new PaintableRoadBike(whitePaintJob);
var order2 = new BicycleOrder(dealership, bicycle2);
orders.AddOrder(order2);

var bicycle3 = new PaintableRecumbent(amarilloPeacockPaintjob);
var order3 = new BicycleOrder(dealership, bicycle3);
orders.AddOrder(order3);

var redPaintJob = new RedPaintJob();
var bicycle4 = new PaintableRoadBike(redPaintJob);
var order4 = new BicycleOrder(dealership, bicycle4);
orders.AddOrder(order4);

// to iterate, just use the normal syntax you use for generic iterators
foreach (BicycleOrder order in orders)
{
    Console.WriteLine(order.Bicycle.PaintJob.Name);
}
