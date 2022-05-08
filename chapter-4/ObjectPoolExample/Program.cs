using ObjectPoolExample;

Console.WriteLine("Here's a program that controls some welding robots from a pool of 10.");

var armPool = new WeldingArmPool
{
    MaxSize = 10
};

// that's it!  We now have a pool of ten arms. (basically a squid)

// let's take one out and send it to station

var arm01 = armPool.GetArmFromPool();
arm01.MoveToStation(1);
if (arm01.DoWeld()) armPool.ReturnArmToPool(arm01);

Console.WriteLine("There are " + armPool.ArmsAvailable + " arms available");
// what if we tried to use too many?
// here we throw a hard error because there are
// literally no more arms in the real world.
// most object pools would go ahead and create
// a new object instead and return that.

for (var i = 0; i < 11; i++)
    try
    {
        var arm = armPool.GetArmFromPool();
        arm.MoveToStation(i + 1);
        arm.DoWeld();
        Console.WriteLine("There are " + armPool.ArmsAvailable + " arms available");
        // fail to send it back so we run out of arms
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }