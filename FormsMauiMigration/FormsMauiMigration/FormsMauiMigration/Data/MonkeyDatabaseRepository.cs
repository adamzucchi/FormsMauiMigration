using System;
using System.Collections.Generic;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Data.Models;
using SQLite;
using System.Threading.Tasks;

namespace FormsMauiMigration.Data
{
	public class MonkeyDatabaseRepository<T> : IDatabaseRepository<T> where T : BaseModel, new()
	{
        internal SQLiteAsyncConnection _databaseConnection;
        private static IDatabaseRepository<T> _databaseRepository;

        public static IDatabaseRepository<T> Current(IMonkeyDatabase monkeyDatabase)
        {
            if(_databaseRepository == null)
            {
                _databaseRepository = new MonkeyDatabaseRepository<T>(monkeyDatabase);
            }

            return _databaseRepository;
        }

        public MonkeyDatabaseRepository(IMonkeyDatabase monkeyDatabase)
        {
            _databaseConnection = monkeyDatabase.Connection;
        }

        #region Methods
        public async Task<List<T>> GetItems()
        {
            List<T> items = null;

            try
            {
                items = await _databaseConnection.Table<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"MonkeyDatabaseRepository.GetItems - Exception: { ex }");
            }

            return items;
        }

        public async Task<T> GetItem(Guid id)
        {
            T item = null;

            try
            {
                item = await _databaseConnection.Table<T>().Where(t => t.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"MonkeyDatabaseRepository.GetItem - Exception: {ex}");
            }

            return item;
        }

        public async Task<bool> Save(T entity)
        {
            bool success = false;

            try
            {
                int updated = await _databaseConnection.InsertOrReplaceAsync(entity);

                if (updated > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"MonkeyDatabaseRepository.Save - Exception: {ex}");
            }

            return success;
        }

        public async Task<bool> SaveAll(IEnumerable<T> entities)
        {
            bool success = true;

            try
            {
                foreach (var item in entities)
                {
                    int updated = await _databaseConnection.InsertOrReplaceAsync(item);
                    if (updated < 1)
                    {
                        success = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"MonkeyDatabaseRepository.SaveAll - Exception: {ex}");
            }

            return success;
        }
        #endregion Methods
    }
}

