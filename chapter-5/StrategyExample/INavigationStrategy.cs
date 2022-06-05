namespace StrategyExample;

public interface INavigationStrategy
{
    public INavigationRoute FindRoute(string parameters);
}