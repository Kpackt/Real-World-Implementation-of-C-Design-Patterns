using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebLogReporter;

namespace WebLogReporterTests
{
    [TestClass]
    public class NginxLogEntryTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testLine = "10.21.30.130 - - [16/Jan/2022:04:00:05 +0000] \"POST /api/update_autobot_process/391643CE-5BC7-43AF-8488-D3672514248A/1358/0 HTTP/ 1.1\" 200 38 \"-\" \"python-requests/2.25.0\"";
            var logEntry = new NginxLogEntry(testLine);

            var expectedIP = "10.21.30.130";
            var expectedRoute = "/api/update_autobot_process/391643CE-5BC7-43AF-8488-D3672514248A/1358/0";
            var expectedVerb = NginxLogEntry.HTTPVerbs.POST;
            var expectedResponseCode = 200;
            var expectedRequestDateTime = new System.DateTime(2022, 1, 16, 4, 0, 5);
            var expectedSizeInBytes = 38;
            var expectedRequestingAgent = "python-requests/2.25.0";

            Assert.AreEqual(logEntry.ServerIPAddress, expectedIP);
            Assert.AreEqual(logEntry.Route, expectedRoute);
            Assert.AreEqual(logEntry.Verb, expectedVerb);
            Assert.AreEqual(logEntry.ResponseCode, expectedResponseCode);
            Assert.AreEqual(logEntry.RequestDateTime, expectedRequestDateTime);
            Assert.AreEqual(logEntry.SizeInBytes, expectedSizeInBytes);
            Assert.AreEqual(logEntry.RequestingAgent, expectedRequestingAgent);

        }
    }
}