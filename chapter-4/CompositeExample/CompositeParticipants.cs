namespace CompositeExample;
// I usually follow the old-school Java convention of one class per file, but in this case the classes are so
// small this seems like its easier to follow.  Each of these components will have other componets within.

public class CrankArm : BicycleComponent
{
    public CrankArm(float weight, float cost) : base(weight, cost)
    {
    }
}

public class LargeChainRing : BicycleComponent
{
    public LargeChainRing(float weight, float cost) : base(weight, cost)
    {
    }
}

public class SmallChainRing : BicycleComponent
{
    public SmallChainRing(float weight, float cost) : base(weight, cost)
    {
    }
}

public class BottomBracket : BicycleComponent
{
    public BottomBracket(float weight, float cost) : base(weight, cost)
    {
    }
}

public class Shaft : BicycleComponent {
    public Shaft(float weight, float cost) : base(weight, cost)
    {
    }
}

public class CrankSet : BicycleComponent {
    public CrankSet(float weight, float cost) : base(weight, cost){}
}