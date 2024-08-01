using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Json_Parser_SQL_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reset the table (drop if exists and recreate)
            using (var context = new ApplicationDbContext())
            {
                context.ResetTable();
                Console.WriteLine("Table has been reset.");
            }

            // Ensure the database is created
            using (var context = new ApplicationDbContext())
            {
                context.Database.EnsureCreated();
            }

            // Path to the JSON file
            //string filePath = @"/Users/anantsingh/Desktop/C#_NET/strawHats.json";
           string filePath = @"/Users/anantsingh/Desktop/IMGC_PMS/PCHFL_MACS.json";

            try
            {
                // Read the JSON file into a string
                string jsonData = File.ReadAllText(filePath);

                // Save JSON data to the database
                using (var context = new ApplicationDbContext())
                {
                    var jsonRecord = new JsonData
                    {
                        JsonContent = jsonData
                    };

                    // Print the JSON data to the console for debugging
                    Console.WriteLine(jsonRecord.JsonContent);
                    //JSON is printing 
                    context.JsonDataSet.Add(jsonRecord);
                    context.SaveChanges();
                }

                Console.WriteLine("JSON data has been saved to the database.");
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, JSON parsing errors)
                Console.WriteLine("An error occurred: " + ex.Message);
                
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                }
            }
        }
    }
}