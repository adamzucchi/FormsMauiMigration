using System;
using SQLite;

namespace FormsMauiMigration.Data.Models
{
	public class BaseModel
	{
		[PrimaryKey]
		public Guid Id { get; set; }
	}
}