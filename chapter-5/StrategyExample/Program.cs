// Let's find some cool bike routes on our new nav computer...

using StrategyExample;

var ctx = new NavigationContext();
ctx.StartNavigation();

// That was too easy.  Let's find a gravel road.

ctx.NavigationStrategy = new GravelNavigationStrategy();
ctx.StartNavigation();

// That was a good workout.  Let's trying something trecherous!

ctx.NavigationStrategy = new MountainNavigationStrategy();
ctx.StartNavigation();

// It doesn't matter if in the future you come up with more algorithms for finding routes.  Just add a new
// class that conforms to the INavigationStrategyInterface and returns something that follows INavigationRoute.

// "follows"  See what I did there?