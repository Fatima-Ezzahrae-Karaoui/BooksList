using Couchbase.Lite;

namespace BooksList.Infrastructure
{
    public class DatabaseManager
    {
        public Database _database;
        public Database GetDatabase()
        {
            if( _database == null )
            {
                var databaseConfig = new DatabaseConfiguration
                {
                    Directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"BookDB")
                };
                _database = new Database("BookDB",databaseConfig);
            }
            return _database;   
        }
    }
}