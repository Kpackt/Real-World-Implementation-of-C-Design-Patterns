# Real-World-Implementation-of-C-Design-Patterns
## Chapter 1 Sample Code
The code in this repository comes from my book on C# patterns.  Organizing a set of files and projects with dependencies between each other in Visual Studio or Rider is pretty easy.  However, the structure created by the IDE is a virtual structure and not a physical structure.  By this, I mean when you make a solution folder in the IDE and group a set of projects together, as I do with each chapter's code, it won't appear the same way in your file explorer as it does in the solution explorer within your IDE.  By extensions, this means links from chapters to the chapter's code in github won't work well either, because GitHub doesn't understand how to display virtual folders.

So to make this work, I left the virtual folder structure intact and created physical folders with links to the chapter code.  Its the best of both worlds.  If you open the book's solution file you'll see the chatper code delineated by chapter, which is again, a virtual structure.  When you browse in GitHub from the links in the text, you'll find a set of files like this one that map the physical structure to the virtual structure used by the IDE.

## In this chapter
In chapter 1 we discuss anti-patterns like the big ball of mud, stovepipe software, and the golden hammer.  The code in this chapter was actually very difficult to write because I had to write code that was intentionally bad and that doesn't use patterns nor follow best practices.

The only project in this chapter is the ```WebLogReporter``` project.  This is a contrived program involving a set of requirements around reading web logs.  Just like in the real world, as our title implies, the requirements change in response to the initial throw-away code's success.  But just because the bosses or clients like the program as is, doesn't mean you should publish what you initially created as a prototype.  Throw-away code often gets published in the name of expediency.  We all aim to keep our clients happy and to get to market as quickly as we can.  The problems begin when you are asked to extend the functionality of your throw-away code.  The text presents the term "stovepipe software" which represents a hastily written program like the WebLogReporter.  It meets an immediate need, but it was coded in under an hour and was never designed to withstand the typical wear and tear of production grade code.

## Building the Project
How you build the project depends on which IDE you're using.  Visual Studio and Rider both have dedicated build and run functions you can use to run each project.  Refer to Appendix 1 of the book if you're not sure how to run a project in your IDE.

Visual Studio Code doesn't have a build / run feature.  Instead you use the command line.  Since that works everywhere, that's what I'm going to document here.

### To run the project:

1. Open the terminal window in Visual Studio Code (Ctrl + `) or run Powershell
2. CD into the ```chapter-1\WebLogReporter``` project folder.  The project folder contains the project file ```WebLogReporter.csproj```.
3. Type ```dotnet build```
4. CD into the build folder.  ```cd .\bin\Debug\net6.0```
5. Copy the sample file into the build folder.  This works consistently.  Sometimes Windows gets confused regarding path names.  ```copy ..\..\..\SampleInputData\nginx-sample.log .```
6. Run the exe.  ```.\WebLogReporter.exe .\nginx-sample.log .\test.html```
7. Verify the output.  It should say it processed 617 log lines assuming no changes to the input file or the code.

## Check out the companion web site
Visit the companion website for this book at [https://csharppatterns.dev](https://csharppatterns.dev)