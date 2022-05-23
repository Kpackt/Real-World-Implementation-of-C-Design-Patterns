using BridgeExample;

Console.WriteLine("Let's make some custom painted mountain bikes");

// Our original mountain bike was black.  We can still do that.
var blackPaintJob = new BlackPaintJob();
var standardMountainBike = new PaintableMountainBike(blackPaintJob);
standardMountainBike.Build();

// For our kickstarter backers, we have the exclusive Mountain Bike with the Amarillo Peacock paint job!
var amarilloPeacockPaintjob = new AmarilloPeacockPaintJob();
var customPaintedMountainBike = new PaintableMountainBike(amarilloPeacockPaintjob);
customPaintedMountainBike.Build();
