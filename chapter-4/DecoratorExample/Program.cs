using BumbleBikesLibrary;
using DecoratorExample;

var regularRoadBike = new RoadBike();  //no decorators.

var bikeManualPrinter = new ManualPrinter();
var documentedBike = new DocumentedBicycle(regularRoadBike, bikeManualPrinter);
documentedBike.Build();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

var manufacturingInventoryNotifier = new MaterialsInventoryNotifier();
var notifierBike = new NotifyingBicycle(regularRoadBike, manufacturingInventoryNotifier);
notifierBike.Build();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

var notifyingDocumentedBike = new NotifyingBicycle(documentedBike, manufacturingInventoryNotifier);
notifyingDocumentedBike.Build();