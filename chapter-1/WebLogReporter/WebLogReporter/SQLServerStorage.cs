using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace WebLogReporter
{
    public class SQLServerStorage
    {
        public void StoreLogLine(NginxLogEntry entry)
        {
            using (SqlConnection con = new SqlConnection("Server=Localhost;Database=WebLogReporter;User Id=SA;Password=P@ssw0rd;"))
            {
                var sql = new StringBuilder("INSERT INTO [dbo].[WebLogEntries] (ServerIPAddress, RequestDateTime, Verb, Route, ResponseCode, SizeInBytes, RequestingAgent) VALUES (");
                sql.Append("'" + entry.ServerIPAddress + "',");
                sql.Append("'" + entry.RequestDateTime + "', ");
                sql.Append("'" + entry.Verb + "', ");
                sql.Append("'" + entry.Route + "', ");
                sql.Append(entry.ResponseCode.ToString() + ", ");
                sql.Append(entry.SizeInBytes.ToString() + ", ");
                sql.Append("'" + entry.RequestingAgent + "')");

                con.Open();
                
                using(SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            
            }
        }

        public List<NginxLogEntry> RetrieveLogLines()
        {
            var logLines = new List<NginxLogEntry>();
            var sql = "SELECT * FROM WebLogEntries";
            using (SqlConnection con = new SqlConnection("Server=Localhost;Database=WebLogReporter;User Id=SA;Password=P@ssw0rd;"))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var serverIPAddress = reader.GetString(1);
                    var requestDateTime = reader.GetDateTime(2);
                    var verb = reader.GetString(3);
                    var route = reader.GetString(4);
                    var responseCode = reader.GetInt32(5);
                    var sizeInBytes = reader.GetInt32(6);
                    var requestingAgent = reader.GetString(7);

                    var line = new NginxLogEntry(serverIPAddress, requestDateTime, verb, route, responseCode, sizeInBytes, requestingAgent);
                    logLines.Add(line);
                }

            }
            return logLines;
        }

                

        
    }
}
