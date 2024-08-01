using System.IO;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Parse_Json;
class Program
{
     static void Main(){
         using(StreamReader reader=new StreamReader(    )){
            //converting from json to C# Object
            string connectionString = "Data Source=localhost;Initial Catalog=Json_Data;Integrated Security=True;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=AnantSingh123";
                 // Deserialize the JSON into a dictionary
                var jsonData = JsonConvert.DeserializeObject<Dictionary<string, List<Pirates>>>(reader.ReadToEnd());
                // Extract the list of pirates
               // System.Console.WriteLine(jsonData);
                var pirates = jsonData["pirates"];
               using (SqlConnection conn = new SqlConnection(connectionString)){
                 conn.Open();
                string query="TRUNCATE TABLE Pirates";
                using(SqlCommand truncateCmd = new SqlCommand(query, conn))
                    {
                        truncateCmd.ExecuteNonQuery();
                    }

               foreach (var member in pirates)
               {
                //System.Console.WriteLine(member.name);
            
                string query1 = "INSERT INTO Pirates (Id, Name, Bounty, Crew) VALUES (@Id, @Name, @Bounty, @Crew)";
                  using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", member.id);
                        cmd.Parameters.AddWithValue("@Name", member.name);
                        cmd.Parameters.AddWithValue("@Bounty", member.bounty);
                        cmd.Parameters.AddWithValue("@Crew", member.crew); 
                        cmd.ExecuteNonQuery();
                    }
               }
            }
               
         }
    }
}