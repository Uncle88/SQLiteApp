using System;
using System.IO;
using SQLiteApp.DependencyService;

namespace SQLiteApp.Droid.DependencyDataBaseServise
{
    public class SQLite_Droid : ISQLite
    {
        public string GetDatabasePath(string filename)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(docpath, filename);

            return path;
        }
    }
}
