using System;
using SQLite;

namespace FormsMauiMigration.Interfaces
{
	public interface IMonkeyDatabase
	{
		SQLiteAsyncConnection Connection { get; }
	}
}