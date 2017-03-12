using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SQLiteApp.ViewModel;
using Xamarin.Forms;

namespace SQLiteApp.ViewModels
{
    public class MarketListViewModel : ViewModelBase
    {
        public ObservableCollection<MarketViewModel> Market { get; set; }

        public ICommand CreateMarketCommand { protected set; get; }
        public ICommand DeleteMarketCommand { protected set; get; }
        public ICommand SaveMarketCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        MarketViewModel selectedItemMarket;

        public INavigation Navigation { get; set; }

        public MarketListViewModel()
        {
            Market = new ObservableCollection<MarketViewModel>();
            CreateMarketCommand = new Command(CreateMarket);
            DeleteMarketCommand = new Command(DeleteMarket);
            SaveMarketCommand = new Command(SaveMarket);
            BackCommand = new Command(Back);
        }

        public MarketViewModel SelectedItemMarket
        {
            get { return selectedItemMarket; }
            set
            {
                if (selectedItemMarket != value)
                {
                    MarketViewModel tempItem = value;
                    selectedItemMarket = null;
                    OnPropertyChanged("SelectedItemMarket");
                    Navigation.PushAsync(new MarketView(tempItem));
                }
            }
        }

        private void CreateMarket()
        {
            Navigation.PushAsync(new MarketView(new MarketViewModel() { marketListViewModel = this }));
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void SaveMarket(object itemObject)
        {
            MarketViewModel item = itemObject as MarketViewModel;
            if (item != null && item.IsValid)
            {
                Market.Add(item);
            }
            Back();
        }

        private void DeleteMarket(object itemObject)
        {
            MarketViewModel item = itemObject as MarketViewModel;
            if (item != null)
            {
                Market.Remove(item);
            }
            Back();
        }
    }
}
