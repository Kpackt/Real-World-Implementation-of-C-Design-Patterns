# Real-World-Implementation-of-C-Design-Patterns
## Chapter 3 Sample Code
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
We finally get to the meat and potatoes of working with patterns.  This chapter presents a common set of patterns
focused on object instantiation which are referred to in the GoF book and other academic literature as *Creation Patterns*.

## Projects (In the order presented within the text)
* [Bumble Bikes Library](/BumbleBikesLibrary) (Note this project is a dependency for many other projects.)
* [No Pattern Example](/NoPattern)
* [Simple Factory Example](/SimpleFactoryExample) (Note this is not a pattern but an idiom.  It is included because it is commonly mistaken for a pattern and it is widely used as such.)
* [Hello World](/HelloWorld) (Yes, Its exactly what you think it is.  It's also the most widely known idiom in the programming world, so it deserves to be here.)
* [Factory Method Example](/FactoryMethodExample)
* [Bicycle Abstract Factory Example](/BicycleAbstractFactoryExample)
* [Bicycle Builder Example](/BicycleBuilderExample)
* [Singleton](/Singleton)
* [Object Pool Example](/ObjectPoolExample)