using SQLite.Net;
using SQLiteApp.DependencyService;
using SQLiteApp.Model;
using Xamarin.Forms;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLiteApp
{
    public class MarketOperation
    {
        public MarketOperation() { }

        SQLiteConnection database;

        public MarketOperation(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Market>();
        }


    }
}
