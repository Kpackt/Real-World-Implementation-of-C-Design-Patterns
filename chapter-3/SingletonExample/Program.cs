using SingletonExample;

Console.WriteLine("Here's a program that controls some welding robots from a pool of 10");
Console.WriteLine(
    "This one uses a singleton version of the object pool making it impossible to instantiate more than once.");

// note the new keyword doesn't work by design.  uncomment the following line if you don't believe me.
// var armPoolSingleton = new WeldingArmPoolSingleton();

// instead you need the static instance property.  it's getter handles the singleton instance for you.
var armPoolSingleton = WeldingArmPoolSingleton.Instance;

var arm01 = armPoolSingleton.GetArmFromPool();
arm01.MoveToStation(1);
if (arm01.DoWeld()) armPoolSingleton.ReturnArmToPool(arm01);

Console.WriteLine("There are " + armPoolSingleton.ArmsAvailable + " arms available");

// now try it again.  it's pointing to the same single instance.  if it weren't there would be 10.

var armPoolSingleton2 = WeldingArmPoolSingleton.Instance;
Console.WriteLine("There are " + armPoolSingleton2.ArmsAvailable + " arms available");