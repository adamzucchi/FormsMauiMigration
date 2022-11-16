using System;
using FormsMauiMigration.Data;

namespace FormsMauiMigration.Interfaces
{
	public interface IDataService
	{
		MonkeyRepository MonkeyRepository { get; }
    }
}