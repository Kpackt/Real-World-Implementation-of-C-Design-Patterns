# WebLogReporter

This was hard to write.  I had to intentionally create code that breaks every rule I'm here to teach you.

## Use Case

As an IT administrator, I would like to be able to easily review weblog traffic by running a command which takes in the location on my computer of a log file from a server running Nginx. I would also like to store the data in a relational database table for future analysis.

GIVEN: I have a log file from Nginx on my computer at [c:\temp\nginx-sample.log](SampleInputData/ngonx-sample.log) AND

GIVEN: I have opened a PowerShell terminal window in Windows 10 or later AND

GIVEN: The WebLogReporter program is listed within my computer's PATH environment variable <br>THEN: I can run the command WebLogReporter, pass the location of the weblog and the path for the output HTML file

GIVEN: The program runs without errors <br> THEN: I am able to view the output HTML file in my favorite browser.

## Acceptance Criteria:
* It's done when I can run the WebLogReporter program with no arguments and receive instructions.
* It's done when I can run the WebLogReporter program with two arguments, consisting of the first being a full path to the Nginx log file I wish to analyze and the second being the full path to the output HTML file I would like the program to produce, and I am able to view the output HTML file within my browser.
* It's done when all the log data are stored in a relational database table so I can query and analyze the data later.

## Sample Input Data
You can find sample input data in the [SampleInputData Folder](SampleInputData/ngonx-sample.log)

## Technical Requirements
* A computer running the Windows operating system.  I’ll bet it works on a Mac, but I haven’t tested anything on MacOS.
* A supported IDE like Visual Studio 2022 (Community or Professional), JetBrains Rider, or Visual Studio Code with the C# extensions.
* .NET 6 Core SDK
* SQL Server.  Any recent version should do.  I'm using SQL Server 2019 Developer Edition.

I really intended this to just be code you reviewed visually and intellectually.  If you actually want to run it, you can,
but you need SQL Server installed and you need to create the schema for the database using the [schema.sql](schema.sql) file.
You'll also need to modify the connection strings in the [SQLServerStorage.cs](SQLServerStorage.cs) file.  Remember, it
s intended to be a throw-away example, so to keep it real, that's hard-coded and checked into revision control.  Gross.  Please don't ever do that with a real project.

