using System.Text;
using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Brakes;
using BumbleBikesLibrary.BicycleComponents.Drivetrain;
using BumbleBikesLibrary.BicycleComponents.Handlebars;
using BumbleBikesLibrary.BicycleComponents.Seats;
using BumbleBikesLibrary.BicycleComponents.Suspensions;

namespace BicycleBuilderExample;

public class BicycleProduct : IBicycleProduct
{
    public IFrame Frame { get; set; }
    public ISuspension Suspension { get; set; }
    public IHandlebars Handlebars { get; set; }
    public IDrivetrain Drivetrain { get; set; }
    public ISeat Seat { get; set; }
    public IBrakes Brakes { get; set; }

    public override string ToString()
    {
        var fullDescription = new StringBuilder("Here's your new bicycle:");
        fullDescription.AppendLine(Frame.ToString());
        fullDescription.AppendLine(Suspension.ToString());
        fullDescription.AppendLine(Handlebars.ToString());
        fullDescription.AppendLine(Drivetrain.ToString());
        fullDescription.AppendLine(Seat.ToString());
        fullDescription.AppendLine(Brakes.ToString());

        return fullDescription.ToString();
    }
}