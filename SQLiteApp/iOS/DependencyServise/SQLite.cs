using System;
using SQLiteApp.DependencyService;
using System.IO;


[assembly: Xamarin.Forms.Dependency(typeof(SQLiteApp.iOS.DependencyServise.SQLite))]

namespace SQLiteApp.iOS.DependencyServise
{
    public class SQLite : ISQLite
    {
        public SQLite() { }

        public string GetDatabasePath(string filename)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string library = Path.Combine(docpath, "...", "Library");
            var path = Path.Combine(library, filename);

            return path;
        }
    }
}
