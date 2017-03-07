using System;
using System.IO;
using SQLite.Net;
using SQLiteApp.Database;
using SQLiteApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Droid))]

namespace SQLiteApp.Droid
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetDatabasePath()
        {
            var fileName = "Market.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}
