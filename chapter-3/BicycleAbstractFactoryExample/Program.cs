using BicycleAbstractFactoryExample;

Console.WriteLine("Let's make some bicycles!");

IBicycleFactory roadBikeFactory = new RoadBicycleFactory();

var frame = roadBikeFactory.CreateBicycleFrame();
var handlebars = roadBikeFactory.CreateBicycleHandleBars();

Console.WriteLine("We just made a road bike!");
Console.WriteLine(frame.ToString());
Console.WriteLine(handlebars.ToString());

IBicycleFactory mountainBikeFactory = new MountainBicycleFactory();
frame = mountainBikeFactory.CreateBicycleFrame();
handlebars = mountainBikeFactory.CreateBicycleHandleBars();
Console.WriteLine("We just made a mountain bike!");
Console.WriteLine(frame.ToString());
Console.WriteLine(handlebars.ToString());