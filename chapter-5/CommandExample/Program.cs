// create a command


using BridgeExample;
using CommandExample;
using FacadeExample;

// we'll be building a mountain bike frame with a black paint job

var blackPaintJob = new BlackPaintJob();
var standardMountainBike = new PaintableMountainBike(blackPaintJob);
var robotArmFacade = new RobotArmFacade(new WelderAttachmentApi(), new BuffingApi(), new GrabbingApi());
var cmd = new BuildFrameCommand(new AssemblyLineReceiver(robotArmFacade), standardMountainBike);

var sender = new Sender(cmd);
sender.DoCommand();
