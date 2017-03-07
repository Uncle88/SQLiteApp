using SQLite.Net;

namespace SQLiteApp.Database
{
    public interface ISQLite
    {
        SQLiteConnection GetDatabasePath();
    }
}
