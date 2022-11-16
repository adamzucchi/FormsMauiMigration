using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormsMauiMigration.Data;

namespace FormsMauiMigration.Interfaces
{
	public interface ICloudService
	{
		Task<IList<Monkey>> GetMonkeys();
	}
}