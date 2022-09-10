using FactoryMethodExample;

Console.WriteLine("Let's make some bicycles"); 
 
var dallasBicycleFactory = new DallasCreator();
var phoebesBike = dallasBicycleFactory.CreateProduct("HILLCREST"); 
phoebesBike.Build(); 
 
var alpineBicycleFactory = new AlpineCreator(); 
var kittysBike = alpineBicycleFactory.CreateProduct("PALO DURO CANYON RANGER"); 
kittysBike.Build();
