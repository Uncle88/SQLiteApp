using Xamarin.Forms;
using SQLiteApp.Model;
using SQLiteApp.ViewModel;

namespace SQLiteApp
{
    public partial class MarketView : ContentPage
    {
        public MarketViewModel _marketViewModel { get; private set; }

        public MarketView(MarketViewModel _mVM)
        {
            InitializeComponent();
            _marketViewModel = _mVM;
            this.BindingContext = _marketViewModel;
        }
    }
}
