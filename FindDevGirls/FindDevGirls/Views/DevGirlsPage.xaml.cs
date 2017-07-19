using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindDevGirls.Models;

using Xamarin.Forms;

namespace FindDevGirls.Views
{
  
    public partial class DevGirlsPage : ContentPage
    {
        public DevGirlsPage()
        {
            InitializeComponent();
            ListViewDevGirls.ItemSelected += ListViewDevGirls_ItemSelected;
        }

        private async void ListViewDevGirls_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedDev = e.SelectedItem as DevGirl;
            if (SelectedDev != null)
            {
                await Navigation.PushAsync(new DetailsPage(SelectedDev));
                ListViewDevGirls.SelectedItem = null;
            }
        }
    }
}
