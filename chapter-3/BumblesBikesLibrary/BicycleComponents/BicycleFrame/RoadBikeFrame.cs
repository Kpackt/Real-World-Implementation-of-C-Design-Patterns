// This is actually a copy of the RoadBike class presented early in the chapter.
// In the real world it would have been refactored as soon as Phoebe realized the bicycle object 
// was going to be more complicated when she worked on implementing the builder pattern.  If I
// had changed the name organically in the process, the earlier part of the chapter's code wouldn't
// match the text, so the class itself is copied and renamed.  It's not DRY but it is more pedagogical.

namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame;

public class RoadBikeFrame : AbstractFrame
{
    public RoadBikeFrame()
    {
        ModelName = "Hillcrest";
        Suspension = SuspensionTypes.Hardtail;
        Color = BicyclePaintColors.Blue;
        Geometry = BicycleGeometries.Upright;
    }
}