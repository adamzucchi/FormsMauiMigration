using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormsMauiMigration.Data;
using FormsMauiMigration.Models;

namespace FormsMauiMigration.Interfaces
{
	public interface ICloudService
	{
		Task<IList<Monkey>> GetMonkeys();
	}
}