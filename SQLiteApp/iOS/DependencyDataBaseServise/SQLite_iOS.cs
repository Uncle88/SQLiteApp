using System;
using SQLiteApp.DependencyService;
using System.IO;

namespace SQLiteApp.iOS.DependencyDataBaseServise
{
    public class SQLite_iOS : ISQLite
    {
        public string GetDatabasePath(string filename)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string library = Path.Combine(docpath, "...", "Library");
            var path = Path.Combine(library, filename);

            return path;
        }
    }
}
