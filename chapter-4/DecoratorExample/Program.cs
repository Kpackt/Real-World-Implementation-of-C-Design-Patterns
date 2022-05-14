using BumbleBikesLibrary;
using DecoratorExample;

var regularRoadBike = new RoadBike();  //no decorators.
var bikeManualPrinter = new ManualPrinter();
var manufacturingInventoryNotifier = new MaterialsInventoryNotifier();

var documentedBike = new DocumentedBicycle(regularRoadBike, bikeManualPrinter);
documentedBike.Build();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

var notifierBike = new NotifyingBicycle(regularRoadBike, manufacturingInventoryNotifier);
notifierBike.Build();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

var notifyingDocumentedBike = new NotifyingBicycle(documentedBike, manufacturingInventoryNotifier);
notifyingDocumentedBike.Build();