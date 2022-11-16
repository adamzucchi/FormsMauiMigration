using System;
using SQLite;
using System.Threading.Tasks;
using FormsMauiMigration.Interfaces;
using System.IO;
using FormsMauiMigration.Data.Models;

namespace FormsMauiMigration.Data
{
	public class MonkeyDatabase : IMonkeyDatabase
    {
        private SQLiteAsyncConnection _database;
        private Task Initialization { get; set; }

        private static IMonkeyDatabase _monkeyDatabase;
        public static IMonkeyDatabase Current()
        {
            if(_monkeyDatabase == null)
            {
                _monkeyDatabase = new MonkeyDatabase();
            }

            return _monkeyDatabase;
        }

        public SQLiteAsyncConnection Connection
        {
            get
            {
                return _database;
            }
        }

        public MonkeyDatabase()
		{
            string filename = "MonkeyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = string.Empty;

            string databaseDirectory = "/database";

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
            {
                string libraryPath = Path.Combine(documentsPath, "..", "Library");

                if (!Directory.Exists(libraryPath + databaseDirectory))
                {
                    Directory.CreateDirectory(libraryPath + databaseDirectory);
                }

                path = Path.Combine(libraryPath + databaseDirectory, filename);
            }
            else
            {
                if (!Directory.Exists(documentsPath + databaseDirectory))
                {
                    Directory.CreateDirectory(documentsPath + databaseDirectory);
                }

                path = Path.Combine(documentsPath + databaseDirectory, filename);
            }

            System.Diagnostics.Debug.WriteLine($"monkey database path: {path}");

            _database = new SQLiteAsyncConnection(path);

            Initialization = InitializationAsync();
        }

        private async Task InitializationAsync()
        {
            await _database.CreateTablesAsync(CreateFlags.None, new Type[1] { typeof(Monkey) });
        }
    }
}

