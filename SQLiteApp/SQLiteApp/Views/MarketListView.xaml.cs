using SQLiteApp.ViewModel;
using SQLiteApp.ViewModels;
using Xamarin.Forms;

namespace SQLiteApp.Views
{
    public partial class MarketListView : ContentPage
    {
        public MarketListView()
        {
            InitializeComponent();
            BindingContext = new MarketListViewModel() { Navigation = this.Navigation };
        }
    }
}