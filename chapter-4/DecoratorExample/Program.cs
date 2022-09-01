using BumbleBikesLibrary;
using DecoratorExample;

var regularRoadBike = new RoadBike();  //no decorators.
regularRoadBike.Build();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

var bikeManualPrinter = new ManualPrinter();
var documentedBike = new DocumentedBicycle(new RoadBike(), bikeManualPrinter);
documentedBike.Build();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

var manufacturingInventoryNotifier = new MaterialsInventoryNotifier();
var notifierBike = new NotifyingBicycle(new RoadBike(), manufacturingInventoryNotifier);
notifierBike.Build();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

var notifyingDocumentedBike = new NotifyingBicycle(new DocumentedBicycle(new RoadBike(), bikeManualPrinter), manufacturingInventoryNotifier);
notifyingDocumentedBike.Build();