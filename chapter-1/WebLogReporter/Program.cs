// before you get too far into this example, please review the README.md file.
using WebLogReporter;

if (args.Length < 2)
{
    Console.WriteLine("You must supply a path to the log file file you want to parse as well as a path for the output.");
    Console.WriteLine(@"For example:  WebLogReporter c:\temp\nginx-sample.log c:\temp\report.html");
    Environment.Exit(1);
}

if (!File.Exists(args[0]))
{
    Console.WriteLine("The path " + args[0] + " is not a valid log file.");
    Environment.Exit(1);
}

var logFileName = args[0];
var outputFile = args[1];

Console.WriteLine("Processing log: " + logFileName);

int lineCounter = 0;
var database = new SQLServerStorage();

foreach(string line in System.IO.File.ReadLines(logFileName))
{

    lineCounter++;
    try
    {
        var logLine = new NginxLogEntry(line);
        database.StoreLogLine(logLine);
    }
    catch 
    { 
        Console.WriteLine("Problem on line " + lineCounter); 
    }

}

var report = new Report();
report.GenerateReport(outputFile);
Console.WriteLine("Processed " + lineCounter + " log lines.");