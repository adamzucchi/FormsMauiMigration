using System;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Data;
using FormsMauiMigration.Data.Models;

namespace FormsMauiMigration.Services
{
	public class DataService : IDataService
	{
		private IMonkeyDatabase _monkeyDatabase;

		private MonkeyRepository _monkeyRepository;

		public DataService(IMonkeyDatabase monkeyDatabase)
		{
			_monkeyDatabase = monkeyDatabase;
		}

		public MonkeyRepository MonkeyRepository
		{
			get
			{
				if(_monkeyRepository == null)
				{
					_monkeyRepository = new MonkeyRepository(_monkeyDatabase);
				}

				return _monkeyRepository;
			}
		}
	}
}

