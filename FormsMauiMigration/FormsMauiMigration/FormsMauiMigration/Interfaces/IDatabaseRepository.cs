using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormsMauiMigration.Data.Models;

namespace FormsMauiMigration.Interfaces
{
	public interface IDatabaseRepository<T> where T : BaseModel, new()
	{
        Task<List<T>> GetItems();
        Task<T> GetItem(Guid id);
        Task<bool> Save(T entity);
        Task<bool> SaveAll(IEnumerable<T> entities);
    }
}