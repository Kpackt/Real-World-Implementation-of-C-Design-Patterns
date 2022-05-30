using System.Numerics;
using BumbleBikesLibrary;
using FacadeExample;

namespace CommandExample;

public class AssemblyLineReceiver
{
    private readonly RobotArmFacade _robotArmFacade;
    private const int NumberOfAssemblyStations = 20;
    private const float ConsistentY = 52.0f;
    private const float ConsistentZ = 128.0f;
    private const float ConsistentW = 90.0f;
    private readonly Quaternion[] _assemblyStations;

    public AssemblyLineReceiver(RobotArmFacade robotArmFacade)
    {
        _robotArmFacade = robotArmFacade;
        _assemblyStations = new Quaternion[NumberOfAssemblyStations];
        
        for (var i = 0; i < NumberOfAssemblyStations; i++)
        {
            var xPosition = i * 25.0f;
            _assemblyStations[i] = new Quaternion(xPosition, ConsistentY, ConsistentZ, ConsistentW);
        }
    }
    public void DoBusinessLogic(IPaintableBicycle bicycle)
    {
        // Now let's follow an abbreviated imaginary assembly of a bicycle frame by controlling a robot arm.
        // grabber gets the frame parts and takes them to station 1
        _robotArmFacade.ActiveAttachment = ArmAttachments.Grabber;
        _robotArmFacade.MoveTo(_assemblyStations[0]);
        _robotArmFacade.Actuate();
        _robotArmFacade.MoveTo(_assemblyStations[1]);
        
        // Once the parts are at station 1, we weld them together
        _robotArmFacade.ActiveAttachment = ArmAttachments.Welder;
        _robotArmFacade.Actuate();
        
        // Now grab the frame and move it to station 4 for painting.  My choice of station 4 is arbitrary.
        _robotArmFacade.ActiveAttachment = ArmAttachments.Grabber;
        _robotArmFacade.Actuate();
        _robotArmFacade.MoveTo(_assemblyStations[4]);
        bicycle.PaintJob.ApplyPrimer();
        bicycle.PaintJob.ApplyPaint();
        bicycle.PaintJob.ApplyTopCoat();
        
        // Finally move the painted frame to station 6 for buffing
        _robotArmFacade.MoveTo(_assemblyStations[6]);
        _robotArmFacade.ActiveAttachment = ArmAttachments.Buffer;
        _robotArmFacade.Actuate();
        
    }
}