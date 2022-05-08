using BicycleBuilderExample;

Console.WriteLine("Let's make some bikes with the builder pattern!");

var roadBikeBuilder = new RoadBikeBuilder();
var director = new Director(roadBikeBuilder);

var roadBike = director.Make();
Console.WriteLine(roadBike.ToString());

// Want mountain bike instead?  just change the builder and do it again
// Could just as easily be a cruiser or a recumbent but let's keep this short.
// FOR THE TREES PEOPLE!

var mountainBikeBuilder = new MountainBikeBuilder();
director.ChangeBuilder(mountainBikeBuilder);

var mountainBike = director.Make();

Console.WriteLine(mountainBike.ToString());