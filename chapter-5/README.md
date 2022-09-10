# Real-World-Implementation-of-C-Design-Patterns
## Chapter 5 Sample Code
The code in this repository comes from my book on C# patterns.  Organizing a set of files and projects
with dependencies between each other in Visual Studio or Rider is pretty easy.  However, the structure
created by the IDE is a virtual structure and not a physical structure.  By this, I mean when you make a solution
folder in the IDE and group a set of projects together, as I do with each chapter's code, it won't appear
the same way in your file explorer as it does in the solution explorer within your IDE.  By extension, this means
links from the chapter's text to the chapter's code in github won't work well either, because GitHub doesn't understand how
to display virtual folders.

So to make this work, I left the virtual folder structure intact and created physical folders with links to the
chapter code.  Its the best of both worlds.  If you open the book's solution file you'll see the chapter code
delineated by chapter, which is again, a virtual structure.  When you browse in GitHub from the links in the text,
you'll find a set of files like this one that map the physical structure to the virtual structure used by the IDE.

## In this chapter
This chapter deals with a class of patterns known as *Behavioral Patterns*.  This group of patterns helps define expressive ways to
define the behavior of the objects within your project.

## Projects in this chapter
* CommandExample
* IteratorExample
* ObserverExample
* StrategyExample

## CommandExample
The Command pattern is one of the most useful you'll find.  It defines a way to send commands to your program in an encapuslated format containing everything necessary to execute the command.  Think about ordering something on line.  You pick the thing, the color, the model, etc.  You give the vendor your address for shipping.  You give them your payment information.  When you click *send* you've sent a command.  The vendor has everything they need to fulfill your order.  This example shows you how to do this with your class structures which are designed to decouple your commands from whatever might execute them.  Think about it.  You can give the same order to any online shop even if the shops are totally different.

### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-4\CommandExample``` project folder.  The project folder contains the project file ```CommandExample.csproj```.
3. Type ```dotnet run```.

## Check out the companion web site
Visit the companion website for this book at [https://csharppatterns.dev](https://csharppatterns.dev)