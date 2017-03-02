namespace SQLiteApp.DependencyService
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
