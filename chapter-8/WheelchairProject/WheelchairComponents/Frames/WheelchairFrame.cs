using WheelchairProject.WheelchairComponents.Axles;
using WheelchairProject.WheelchairComponents.Casters;

namespace WheelchairProject.WheelchairComponents.Frames;

public abstract class WheelchairFrame : WheelchairComponent
{
    public Axle Axle { get; set; }
    public CasterAssembly Casters { get; set; }
}