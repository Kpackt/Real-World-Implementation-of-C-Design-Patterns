# Real-World-Implementation-of-C-Design-Patterns
## Chapter 7 Sample Code
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
This book was originally planned to consist of nine chapters, making this seven of nine.  So this chapter is
partially dedicated to [Jeri Ryan](https://www.imdb.com/name/nm0005394/) who played the character *Seven of Nine*, on
the TV show *Star Trek Voyager*, and other productions within the *Star Trek* franchise.  Thank you, Jeri for being
part of something that inspired our collective futures.

While Ryan played a conflicted hero on television and in the movies, the real heroes represented in the chapter's
story line are all the children, and their families and care-takers suffering from rare and debilitative auto-immune
diseases like juvenile dermatomyositis, polymyositis, and myositis.  Rare diseases are not covered by health
insurance in the United States, so to add to the pain and life altering physical detriment conferred by the disease itself, many families go bankrupt
trying to keep their child or family member alive.  Having suffered from it myself for over six years, I can attest
to the pain and difficulties first-hand.  As I write this, in May of 2022, it is *Myositis Awareness Month*.  To learn
more about the myositis diseases, check out [myositis.org](https://www.myositis.org/).

In the previous chapter we developed a set of UML diagrams for a new project.  There was no code in the last chapter. 
We make up for it here since this chapter presents the implementation of the plan and diagrams created previously.

## Projects (In the order presented within the text)
There is only one.  The [wheelchair](/Wheelchair) project.