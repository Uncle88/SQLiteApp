using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using SQLiteApp.Database;
using SQLiteApp.Model;
using Xamarin.Forms;


namespace SQLiteApp
{
    public class MarketOperation
    {
        private SQLiteConnection _sqliteConnection;

        public MarketOperation()
        {
            //string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            //database = new SQLiteConnection(databasePath);
            //database.CreateTable<Market>();
            _sqliteConnection = DependencyService.Get<ISQLite>().GetDatabasePath();
            _sqliteConnection.CreateTable<Market>();
        }

        public IEnumerable<Market> GetItems()
        {
            return (from i in _sqliteConnection.Table<Market>() select i).ToList();
        }

        public Market GetProduct(int id)
        {
            return _sqliteConnection.Get<Market>(id);
        }

        public int DeleteProduct(int id)
        {
            return _sqliteConnection.Delete<Market>(id);
        }

        public int SaveProduct(Market item)
        {
            if (item.Id != 0)
            {
                _sqliteConnection.Update(item);
                return item.Id;
            }
            else
            {
                return _sqliteConnection.Insert(item);
            }
        }
    }
}
