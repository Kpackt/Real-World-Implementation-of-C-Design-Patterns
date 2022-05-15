using System.Numerics;

namespace FacadeExample;

public enum ArmAttachments { Welder, Buffer, Grabber }
public class RobotArmFacade
{
    private readonly WelderAttachmentApi _welder;
    private readonly BuffingApi _buffer;
    private readonly GrabbingApi _grabber;
    public ArmAttachments ActiveAttachment;
    public RobotArmFacade(WelderAttachmentApi welder, BuffingApi buffer, GrabbingApi grabber)
    {
        _welder = welder;
        _buffer = buffer;
        _grabber = grabber;
        ActiveAttachment = ArmAttachments.Welder;
    }

    public void Actuate()
    {
        switch (ActiveAttachment)
        {
            case ArmAttachments.Buffer:
                _buffer.Buff();
                break;
            case ArmAttachments.Grabber:
                _grabber.Grab();
                break;
            case ArmAttachments.Welder:
                _welder.Weld();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void MoveTo(Quaternion quaternion)
    {
        var roundX = (int)Math.Round(quaternion.X, 0);
        var roundY = (int)Math.Round(quaternion.Y, 0);
        var roundZ = (int)Math.Round(quaternion.Z, 0);
        
        switch (ActiveAttachment)
        {
            case ArmAttachments.Buffer:
                _buffer.Position(quaternion);
                break;
            case ArmAttachments.Welder:
                _welder.MoveTo(roundX, roundY, roundZ);
                break;
            case ArmAttachments.Grabber:
                _grabber.SetLocation(roundX, roundY);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}