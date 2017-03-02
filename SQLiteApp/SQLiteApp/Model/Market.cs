using SQLite.Net.Attributes;

namespace SQLiteApp.Model
{
    [Table("Market")]
    public class Market
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Price { get; set; }
    }
}
