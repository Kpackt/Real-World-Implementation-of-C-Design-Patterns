// See https://aka.ms/new-console-template for more information

using WheelchairProject.Builders;

Console.WriteLine("Hello, World!  Let's make some Plano Wheelchairs");

var builder = new PlanoWheelchairBuilder();
var director = new WheelchairBuilderDirector(builder);

var planoWheelchair = director.Build();
planoWheelchair.DisplayCost();
planoWheelchair.DisplayWeight();
