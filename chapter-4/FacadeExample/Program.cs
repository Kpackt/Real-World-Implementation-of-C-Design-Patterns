using FacadeExample;
using System.Numerics;

const int numberOfAssemblyStations = 20;
const float consistentY = 52.0f;
const float consistentZ = 128.0f;
const float consistentW = 90.0f; 
var assemblyStations = new Quaternion[numberOfAssemblyStations];
for (var i = 0; i < numberOfAssemblyStations; i++)
{
    var xPosition = i * 25.0f;
    assemblyStations[i] = new Quaternion(xPosition, consistentY, consistentZ, consistentW);
}

Console.WriteLine("RobotArm 0: Robotic arm control system activated!");
var robotArm0 = new RobotArmFacade(new WelderAttachmentApi(), new BuffingApi(), new GrabbingApi());

Console.WriteLine("Initializing welder function in arm 0");
robotArm0.ActiveAttachment = ArmAttachments.Welder;
robotArm0.MoveTo(assemblyStations[0]);
robotArm0.Actuate();

Console.WriteLine("Initializing buffer function in arm 0");
robotArm0.ActiveAttachment = ArmAttachments.Buffer;
robotArm0.MoveTo(assemblyStations[3]);
robotArm0.Actuate();

Console.WriteLine("Initializing grabber function in arm 0");
robotArm0.ActiveAttachment = ArmAttachments.Grabber;
robotArm0.MoveTo(assemblyStations[7]);
robotArm0.Actuate();