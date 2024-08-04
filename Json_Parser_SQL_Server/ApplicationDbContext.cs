using Microsoft.EntityFrameworkCore;
using Json_Parser_SQL_Server;


    public class ApplicationDbContext : DbContext
    {
        public DbSet<JsonData> JsonDataSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Json_Data;Integrated Security=True;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=AnantSingh123");
        }


        public void ResetTable()
        {
            // Drop the table if it exists
            Database.ExecuteSqlRaw("IF OBJECT_ID('JsonStorage', 'U') IS NOT NULL DROP TABLE JsonStorage");

            // Create a new table
            Database.ExecuteSqlRaw(@"
                CREATE TABLE JsonStorage
                (
                    Id INT PRIMARY KEY IDENTITY, -- Primary key with auto-increment
                    JsonContent NVARCHAR(MAX) -- Column to store JSON data
                )");
        }
    }

