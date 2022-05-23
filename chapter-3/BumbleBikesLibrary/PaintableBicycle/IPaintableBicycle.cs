using BumbleBikesLibrary.PaintableBicycle;

namespace BumbleBikesLibrary;

// same as IBicycle but with paint color enum removed
// see the chapter on the Bridge pattern
public interface IPaintableBicycle : ISimplifiedBicycle
{
 IPaintJob PaintJob { get; set; } 
}