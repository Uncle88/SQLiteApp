using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SQLiteApp.Views
{
    public partial class ListProductView : ContentView
    {
        public ListProductView()
        {
            InitializeComponent();
        }

        public static explicit operator Page(ListProductView v)
        {
            throw new NotImplementedException();
        }
    }
}
