// before you get too far into this example, please review the README.md file.
using System.Globalization;

namespace WebLogReporter
{
    public class NginxLogEntry
    {
        public enum HTTPVerbs { GET, POST, PUT, DELETE }
        public string ServerIPAddress { get; set; }
        public DateTime RequestDateTime { get; set; }
        public HTTPVerbs Verb { get; set; }
        public string Route { get; set; }
        public int ResponseCode { get; set; }
        public int SizeInBytes { get; set; }
        public string RequestingAgent { get; set; }

        public NginxLogEntry(String LogLine)
        {
            // More sample data can be found in the SampleInputData folder of this project.
            var parts = LogLine.Split(' ');
            if(parts.Length < 12)
            {
                Console.WriteLine(LogLine);
            }
            ServerIPAddress = parts[0];
            
            var rawDateTime = parts[3].Split(' ')[0].Substring(1).Trim();
            RequestDateTime = DateTime.ParseExact(rawDateTime, "dd/MMM/yyyy:HH:mm:ss", CultureInfo.InvariantCulture);

            var rawVerb = parts[5].Trim().Substring(1);  // strips off the leading quote character
            Verb = (HTTPVerbs)Enum.Parse(typeof(HTTPVerbs), rawVerb);  // convert to enumeration

            Route = parts[6].Trim();
            ResponseCode = int.Parse(parts[8].Trim());
            SizeInBytes = int.Parse(parts[9].Trim());
            RequestingAgent = parts[11].Replace("\"", null);
        }

        public NginxLogEntry(string serverIPAddress, DateTime requestDateTime, string verb, string route, int responseCode, int sizeInBytes, string requestingAgent)
        {
            RequestDateTime = requestDateTime;
            Verb = (HTTPVerbs)Enum.Parse(typeof(HTTPVerbs), verb);
            Route = route;
            ResponseCode = responseCode;
            SizeInBytes = sizeInBytes;
            RequestingAgent = requestingAgent;
        }
    }
}