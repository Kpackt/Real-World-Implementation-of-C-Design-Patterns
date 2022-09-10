# Real-World-Implementation-of-C-Design-Patterns
## Chapter 4 Sample Code
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
This chapter deals with a class of patterns known as *Structural Patterns*.  This group of patterns assists with building larger structures.
What a creation pattern is to a single class, a structural pattern is to a larger project.

## Projects in this chapter
* Bridge Example
* Composite Example
* Decorator Example
* Facade Example

## BridgeExample
This is an example of an implementation of the Bridge pattern.  The Bridge pattern is used when you want to de-couple to complicated parts of an object graph and manage them separately.  In the book we vary the bicycle classes along with some new paint classes.  Both are complicated.  They key to the bridge pattern is straightforward composition.

## Check out the companion web site
Visit the companion website for this book at [https://csharppatterns.dev](https://csharppatterns.dev)
