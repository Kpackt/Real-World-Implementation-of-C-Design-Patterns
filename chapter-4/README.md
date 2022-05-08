# Real World Implementation of C# Design Patterns
## Chapter 4:  Creation Patterns
### Bruce Van Horn

## Overview
Creation patterns deal with the creation of objects, a process we call *instantiation*.  Remember, an object is a class that has been instantiated.  Objects only exist in running programs.  They are built from blueprints called *classes*.  Since C# is a static language, you can’t generally change the structure of an object once it has been instantiated, which means you should take care to use the best strategy to create your objects.  That’s what we’re discussing in this chapter, and that is what I show in the supporting source code within these files.

## Patterns in This Chapter
* The Simple Factory (technically not a pattern)
* The Factory Method Pattern
* The Abstract Factory Pattern
* The Builder Pattern
* The Object Pool Pattern
* The Singleton Pattern

## Technical Requirements
Throughout the book, I assume you know how to create new C# projects in your favorite integrated development environment (IDE), so I don’t spend any time on the mechanics of setting up and running projects.  Should you decide to try any of this out, you’ll need the following:
- A computer running the Windows operating system.  I’m using Windows 10.  Since the projects are simple command-line projects, I’m pretty sure everything here would also work on a Mac or Linux, but I haven’t tested the projects on those operating systems.
- A supported IDE like Visual Studio, JetBrains Rider, or Visual Studio Code with C# extensions.  I’m using Rider 2021.3.3.
- Some version of the .NET SDK.  Again, the projects are simple enough that our code shouldn’t be reliant on any particular version.  I happen to be using the .NET Core 6 SDK.
