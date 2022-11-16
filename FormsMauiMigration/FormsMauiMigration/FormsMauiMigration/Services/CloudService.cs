using System;
using FormsMauiMigration.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Models;

namespace FormsMauiMigration.Services
{
	public class CloudService : ICloudService
	{
		public async Task<IList<Monkey>> GetMonkeys()
		{
			//simulate a delay
			await Task.Delay(500);

			return MonkeyData.Monkeys;
		}
    }
}