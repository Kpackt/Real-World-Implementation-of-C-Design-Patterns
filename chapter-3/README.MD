# Real-World-Implementation-of-C-Design-Patterns
![Kitty and Phoebe with one of their first bikes, and their first robots](kitty-and-phoebe-bikes-robots.png)
## Chapter 3 Getting Creative with Creation Patterns
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

## Projects in this chapter
* BicycleAbstractFactoryExample
* BicycleBuilderExample
* BumbleBikesLibrary
* FactoryMethodExample
* HelloWorld (Yes, really!)
* NoPattern
* ObjectPoolExample
* SimpleFactoryExample
* SingletonExample

## BicycleAbstractFactoryExample
This project shows an implementation of the *Abstract Factory* example.  You use this pattern when you have families of related objects you need to instantiate together.

### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-3\BicycleAbstractFactoryExample``` project folder.  The project folder contains the project file ```BicycleAbstractFactoryExample.csproj```.
3. Type ```dotnet run```.

## BicycleBuilderExample
This project shows an implementation of the *Builder* pattern.  This pattern is used to build complicated objects where settingup the object consists of many steps.  It was the creation pattern of choice for Kitty, Phoebe and Tom in Chapter 3-8 owing to the complex nature of the bicycle objects.  

### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-3\BicycleBuilderExample``` project folder.  The project folder contains the project file ```BicycleAbstractFactoryExample.csproj```.
3. Type ```dotnet run```.

## BumbleBikesLibrary
This is a library Kitty created in Chapter 3 (this chapter).  It's purpose is to hold any class or interface that might be reused in any project throughout the book.  The girls add code here when there's even a chance the code might be reused.  This prevents succumbing to the temptation to copy files into muliple projects.  The code should always be DRY as discussed in Chapter 2.

### To run the project:
This is a library project.  You don't run it.  It is used by the other projects in the book by declaring this library as a dependency.

## FactoryMethodExample
The factory method is what most people think of when they think about a factory pattern.  There are other factories that are either different (like Abstract Factory) or not patterns at all (like Simple Factory).  The Factory Method pattern truly abstracts the creation process when you have a variety of object types to instantiate.

### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-3\FactoryMethodExample``` project folder.  The project folder contains the project file ```FactoryMethodExample.csproj```.
3. Type ```dotnet run```.

## Hello world
This is not a pattern, it is an idiom.  It is used as an example in the book, which means I had to created, which means it wound up in the repository.  I doubt you need any further instructions on this one.

## NoPattern
As the project name implies, this is where Kitty and Phoebe start their work.  It shows a simple instantiation of objects in the client program.  Code like this is **very** common.  It is also brittle.

### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-3\NoPattern``` project folder.  The project folder contains the project file ```NoPattern.csproj```.
3. Type ```dotnet run hillcrest```.

This program takes a command line argument.  You pass in the model name of the bicycle you want to create.  I've added ```hillcrest```, but you can use any of the models from the book.

## ObjectPoolExample
Object pools are used when you have an object that is computationally expensive to instantiate over and over again.  The classic example is database connections.  Connecting to a relational database is one of the slowest things any program can do.  If your code manages thousands of database connections per hour, you are wasting a lot of time handling connections.

An object pool consists of a collection of pre-instantiated objects that can be recycled.  You can create a dozen connections of a database and leave them active.  Then everytime your program needs a connection, they get one from the pool.  Instead of closing the connection, the connection object is returned to the pool to be used by other requests.

### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-3\ObjectPoolExample``` project folder.  The project folder contains the project file ```ObjectPoolExample.csproj```.
3. Type ```dotnet run```.

Note this one simulates objects being taken out of the pool along with what happens when the pool is empty.

## SimpleFactoryExample
This isn't a patter.  It is an idiom.  In the NoPattern project we had bare instantiation in the client program.  In a simple factory, a developer just moves that instantiate code into a class and calls it a factory.  If you want a *real* factory pattern, and your needs are simple, you probably want the Factory Method pattern.

### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-3\SimpleFactoryExample``` project folder.  The project folder contains the project file ```SimpleFactoryExample.csproj```.
3. Type ```dotnet run hillcrest```.

This program takes a command line argument.  You pass in the model name of the bicycle you want to create.  I've added ```hillcrest```, but you can use any of the models from the book.

## Singleton
The singleton pattern is controversial.  Some developers consider it an anti-pattern.  However, if we set aside our prejudice, a singleton is an object that can only be instantiated one time.  The class contains a reference to itself and it detects when you try to instantiate a second object.  When this happens you get back the first object that was instantiated.  Like the Object Pool pattern, this one comes in handy when you have some computationally expensive class that takes time to instantiate over and over again.  Object Pool gives you a bunch of reusable objects.  This pattern gives you exactly one object that is effectively a global object that can be used from anywhere in your program.
### To run the project:
1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-3\SingletonExample``` project folder.  The project folder contains the project file ```SingletonExample.csproj```.
3. Type ```dotnet run```.

## Check out the companion web site
Visit the companion website for this book at [https://csharppatterns.dev](https://csharppatterns.dev)