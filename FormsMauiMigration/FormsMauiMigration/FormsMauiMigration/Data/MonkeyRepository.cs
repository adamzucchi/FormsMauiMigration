using System;
using FormsMauiMigration.Data;
using FormsMauiMigration.Data.Models;
using FormsMauiMigration.Interfaces;

namespace FormsMauiMigration.Data
{
	public class MonkeyRepository : MonkeyDatabaseRepository<Monkey>
	{
		public MonkeyRepository(IMonkeyDatabase monkeyDatabase) : base(monkeyDatabase){}
	}
}