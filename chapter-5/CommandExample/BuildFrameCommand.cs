using BumbleBikesLibrary;

namespace CommandExample;

public class BuildFrameCommand : ICommand
{
    private AssemblyLineReceiver _assemblyLineReceiver;
    private IPaintableBicycle _bicycle;
    public BuildFrameCommand(AssemblyLineReceiver assemblyLineReceiver, IPaintableBicycle bicycle)
    {
        _assemblyLineReceiver = assemblyLineReceiver;
        _bicycle = bicycle;
    }
    
    public void Execute()
    {
        _assemblyLineReceiver.DoBusinessLogic(_bicycle);
    }
}