using System;
using System.ComponentModel;
using SQLiteApp.Model;
using SQLiteApp.ViewModels;

namespace SQLiteApp.ViewModel
{
    public class MarketViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanget;
        MarketListViewModel _marketListVM;

        public string _name;
        public string _manufacturer;
        public string _price;

        public Market _market { get; private set; }

        public MarketViewModel()
        {
            _market = new Market();
        }

        public MarketListViewModel marketListViewModel
        {
            get { return _marketListVM; }
            set
            {
                if (value != _marketListVM)
                {
                    _marketListVM = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                if (value != _manufacturer)
                {
                    _manufacturer = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Price
        {
            get { return _price; }
            set
            {
                if (value != _price)
                {
                    _price = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((string.IsNullOrEmpty(Name.Trim())) ||
                    (string.IsNullOrEmpty(Manufacturer.Trim())) ||
                        (string.IsNullOrEmpty(Price.Trim())));
            }
        }

        //public Market _market;
        //public MarketOperation _marketOperation;

        // public void adddata(object s, EventArgs args)
        // {
        //     _market = new Market();
        //     _marketOperation = new MarketOperation();
        //     _market.Name = name.Text;
        //     _market.Manufacturer = manufacturer.Text;
        //     _market.Price = price.Text;
        //     _market.Id++;
        //     _marketOperation.SaveProduct(_market);
        // }

        // public void Showdata(object sender, EventArgs args)
        // {
        //     Navigation.PushModalAsync(new ListProduct());
        // }
    }
}
