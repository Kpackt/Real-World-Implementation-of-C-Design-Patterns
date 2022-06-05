namespace StrategyExample;

public class NavigationContext
{
    public INavigationStrategy NavigationStrategy { get; set; }

    public NavigationContext()
    {
        NavigationStrategy = new RoadNavigationStrategy();
    }
    public void StartNavigation()
    {
        // things happen here until eventually...
        var route = NavigationStrategy.FindRoute("parameters goe here");
        Console.WriteLine(route.RouteDetails);

    }
}