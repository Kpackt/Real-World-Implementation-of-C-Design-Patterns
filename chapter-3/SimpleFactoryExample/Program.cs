using SimpleFactoryExample;

const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike";

if (args.Length > 0)
{
    var bicycleType = args[0].Trim().ToLower();
    var bicycleFactory = new SimpleBicycleFactory();
    var bikeToBuild = bicycleFactory.CreateBicycle(bicycleType);
    bikeToBuild.Build();
}
else
{
    Console.WriteLine(errorText);
}