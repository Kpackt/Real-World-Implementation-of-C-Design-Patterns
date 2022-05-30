namespace MementoExample;
using BumbleBikesLibrary;
public class ManufacturingOriginator
{
    /***********************************************************/
    private class ManufacturingState
    {
        private const int MaxStationNumber = 19;
        private const int MinStationNumber = 0;
        public ManufacturingStatus CurrentStatus { get; }
        public DateTime LastTransition { get; set; }

        private int _lastStationNumber;
        public int LastStation
        {
            get => _lastStationNumber;
            set
            {
                if (value is >= MinStationNumber and <= MaxStationNumber)
                {
                    _lastStationNumber = value;
                }
            }
        }
        
        public ManufacturingState()
        {
            CurrentStatus = ManufacturingStatus.Specified;
            LastTransition = DateTime.Now;
            LastStation = 0;
        }
    }
    /***********************************************************/

    private ManufacturingState State { get; set; }
    
    public ManufacturingOriginator()
    {
        State = new ManufacturingState();
    }

}