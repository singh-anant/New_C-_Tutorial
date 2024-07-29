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
         using(StreamReader reader=new StreamReader(@"/Users/anantsingh/Desktop/C#_NET/strawHats.json")){
            //converting from json to C# Object
            string connectionString = "Data Source=localhost;Initial Catalog=Json_Data;Integrated Security=True;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=AnantSingh123";
               var pirates=JsonConvert.DeserializeObject<List<Pirates>>(reader.ReadToEnd());
               using (SqlConnection conn = new SqlConnection(connectionString)){
               conn.Open();
               foreach (var member in pirates)
               {
                //System.Console.WriteLine(member.name);
                string query = "INSERT INTO Pirates (Id, Name, Bounty, Crew) VALUES (@Id, @Name, @Bounty, @Crew)";
                  using (SqlCommand cmd = new SqlCommand(query, conn))
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