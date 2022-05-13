# Real-World-Implementation-of-C-Design-Patterns
## Appendix Sample Code
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

## In this appendix
I wrote this appendix originally as the second chapter of the book.  After moving it around a few times my
wise and talented editor suggested we make this an appendix.  I loved the idea.  The book proper is really
designed for developers with a certain level of faculty with C# and their IDE of choice.  It isn't intended for
beginners.  With that said, shouldn't it be?  I think we absolutely *should* teach beginners to code with
patterns, but not necessarily inline with the usual instruction of OOP or C# in particular.  The original
chapter sought to level-set and make sure everybody is on the same page with respect to understanding the basic
qualities of OOP and how the operate in the C# language in particular.  I also wanted the book to be at least
somewhat accessible to my students at Southern Methodist University.  However, I don't each C# but rather
JavaScript as part of a full stack curriculum.  They don't know C#, but they come out knowing a lot about OOP 
as implemented in JavaScript, which being a dynamic language with prototype inheritance and a weak type system, is
very different than C#'s static class-based framework.

There aren't any projects in the appendix, just snippets for the sake of example.