using Xamarin.Forms;

namespace SQLiteApp.Views
{
    public partial class ListProduct : ContentPage
    {
        public MarketOperation _database;

        public ListProduct()
        {
            InitializeComponent();

            _database = new MarketOperation();
            var products = _database.GetItems();
            ListProductView.ItemsSource = products;
        }
    }
}
