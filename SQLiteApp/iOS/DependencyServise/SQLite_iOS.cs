using System;
using System.IO;
using SQLite.Net;
using SQLiteApp.Database;
using SQLiteApp.iOS;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(SQLite_iOS))]

namespace SQLiteApp.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite.Net.SQLiteConnection GetDatabasePath()
        {
            var fileName = "Market.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, path);

            return connection;
        }
    }
}
