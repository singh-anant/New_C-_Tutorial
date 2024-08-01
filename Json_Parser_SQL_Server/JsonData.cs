using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Json_Parser_SQL_Server
{
     [Table("JsonStorage")]
    public class JsonData
    {
    [Key]
    public int Id { get; set; } // Primary key
    
    [Column(TypeName = "nvarchar(max)")]
    public string JsonContent{ get; set; } // Column to store JSON data
    }
}