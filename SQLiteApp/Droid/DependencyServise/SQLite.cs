using System;
using System.IO;
using SQLiteApp.DependencyService;


[assembly: Xamarin.Forms.Dependency(typeof(SQLiteApp.Droid.DependencyServise.SQLite))]

namespace SQLiteApp.Droid.DependencyServise
{
    public class SQLite : ISQLite
    {
        public SQLite() { }

        public string GetDatabasePath(string filename)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(docpath, filename);

            return path;
        }
    }
}
