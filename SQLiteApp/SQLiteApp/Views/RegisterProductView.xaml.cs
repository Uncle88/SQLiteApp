using Xamarin.Forms;
using SQLiteApp.Model;
using System;
using SQLiteApp.Views;

namespace SQLiteApp
{
    public partial class RegisterProductView : ContentPage
    {
        public Market _market;
        public MarketOperation _marketOperation;

        public RegisterProductView()
        {
            InitializeComponent();
        }

        public void adddata(object s, EventArgs args)
        {
            _market = new Market();
            _marketOperation = new MarketOperation();
            _market.Name = name.Text;
            _market.Manufacturer = manufacturer.Text;
            _market.Price = price.Text;
            _market.Id++;
            _marketOperation.SaveProduct(_market);
        }

        public void Showdata(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ListProduct());
        }
    }
}
