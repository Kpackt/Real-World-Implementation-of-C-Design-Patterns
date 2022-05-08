using BumbleBikesLibrary.Robotics.Arms;

namespace SingletonExample;

public sealed class WeldingArmPoolSingleton
{
    private static WeldingArmPoolSingleton _instance;
    private int _maxSize = 10;

    private WeldingArmPoolSingleton()
    {
        Reset();
    }

    public static WeldingArmPoolSingleton Instance
    {
        get
        {
            if (_instance == null) _instance = new WeldingArmPoolSingleton();
            return _instance;
        }
    }

    private List<WeldingArm> Pool { get; set; }

    public int MaxSize
    {
        get => _maxSize;
        set
        {
            _maxSize = value;
            Reset();
        }
    }

    public int ArmsAvailable => Pool.Count;


    public void Reset()
    {
        Pool = new List<WeldingArm>();
        for (var i = 0; i < MaxSize; i++) Pool.Add(new WeldingArm());
    }

    public WeldingArm GetArmFromPool()
    {
        if (ArmsAvailable > 0)
        {
            var returnArm = Pool[0];
            Pool.RemoveAt(0);
            return returnArm;
        }

        throw new Exception("You are out of arms.  Return some to the pool and try again.");
    }


    public void ReturnArmToPool(WeldingArm arm)
    {
        arm.CurrentPosition = 0; //not at any station
        Pool.Add(arm);
    }
}