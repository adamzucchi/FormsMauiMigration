using System;
using SQLite;

namespace FormsMauiMigration.Data.Models
{
	[Table("Monkey")]
	public class Monkey : BaseModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
    }
}