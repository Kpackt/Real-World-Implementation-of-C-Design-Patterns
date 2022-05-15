using CompositeExample;

Console.WriteLine("Composite Example");

// for this exercise, a crankset is comprised of the bottom bracket, two chain rings, the crank arms and pedals
// I think it's easiest to go bottom up starting with the leaves.

var leftPedal = new Pedal(234.14f, 11.32f);
var rightPedal = new Pedal(234.14f, 11.32f);

// the pedals connect to the crank arm
var crankArm = new CrankArm(432.93f, 34.32f);
crankArm.SubComponents.Add(leftPedal);
crankArm.SubComponents.Add(rightPedal);

// the crank arm connects to the large chain ring
// the large chain ring has a small chain ring attached
var largeChainRing = new LargeChainRing(57.0983f, 13.53f);
var smallChainRing = new SmallChainRing(52.57f, 11.33f);

largeChainRing.SubComponents.Add(smallChainRing);
largeChainRing.SubComponents.Add(crankArm);

// the large chain ring connects to the shaft
var shaft = new Shaft(82.03f, 19.55f);
shaft.SubComponents.Add(largeChainRing);

// finally, the shaft threads through the bottom bracket to form a system called the crank set.
var bottomBracket = new  BottomBracket(284.834f, 11.51f);
bottomBracket.SubComponents.Add(shaft);

var crankSet = new CrankSet(0f, 0f);  // I used 0's because the crank set is the sum of its parts
crankSet.SubComponents.Add(bottomBracket);

Console.WriteLine(" ------------------------ Weights --------------------------");
crankSet.DisplayWeight();

Console.WriteLine(" ------------------------ Cost --------------------------");
crankSet.DisplayCost();
