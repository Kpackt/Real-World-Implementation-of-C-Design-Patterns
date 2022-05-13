namespace BumbleBikesLibrary.Robotics.Arms;

public enum WelderTypes
{
    MIIG,
    TIG,
    Stick
}

public class WeldingArm
{
    public WeldingArm()
    {
        DutyHours = 0.0f;
        InputVoltage = 120;
        OutputRangeMin = 10;
        OutputRangeMax = 140;
        Type = WelderTypes.TIG;
        CurrentPosition = 0;
    }

    public float DutyHours { get; set; } // milliseconds
    public float InputVoltage { get; set; } // volts AC
    public float OutputRangeMin { get; set; } // amps
    public float OutputRangeMax { get; set; } // amps
    public WelderTypes Type { get; set; }

    public int
        CurrentPosition { get; set; } // the station number for the weld (1-10 but there will be more in the future)

    public void MoveToStation(int stationId)
    {
        CurrentPosition = stationId;
    }

    public bool DoWeld()
    {
        //IRL you'd have code here.
        const int timeToWeld = 5000; // it takes 5 seconds to do a weld
        Thread.Sleep(timeToWeld);
        IncrementDutyHours(timeToWeld);
        return true;
    }

    private void IncrementDutyHours(float milliseconds)
    {
        DutyHours += milliseconds;
    }
}