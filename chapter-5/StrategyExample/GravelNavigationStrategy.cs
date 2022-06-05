namespace StrategyExample;

public class GravelNavigationStrategy : INavigationStrategy
{
    public INavigationRoute FindRoute(string parameters)
    {
        // This is where your amazing algorithm goes.  But since this is a book on patterns and not algorithms...
        return new NavigationRoute
        {
            RouteDetails = "I'm a gravel route."
        };
    }
}