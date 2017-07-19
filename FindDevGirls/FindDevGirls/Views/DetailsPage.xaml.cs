using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindDevGirls.Models;

using Xamarin.Forms;

namespace FindDevGirls.Views
{
    public partial class DetailsPage : ContentPage
    {
        DevGirl SelectedDev;
        public DetailsPage(DevGirl selectedDevGirl)
        {
            this.SelectedDev = selectedDevGirl;
            BindingContext = this.SelectedDev;
            InitializeComponent();

            ButtonFacebook.Clicked += ButtonFacebook_Clicked;
            ButtonGithub.Clicked += ButtonGithub_Clicked;
            ButtonGoogle.Clicked += ButtonGoogle_Clicked;
            ButtonTwitter.Clicked += ButtonTwitter_Clicked;
        }

        private void ButtonTwitter_Clicked(object sender, EventArgs e)
        {
            if (SelectedDev.GooglePlus != null)
            {
                var twitter_dev = "http://twitter.com/" + SelectedDev.Twitter;
                Device.OpenUri(new Uri(twitter_dev));
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Twitter não informado", "Ok");
            }
        }

        private void ButtonGoogle_Clicked(object sender, EventArgs e)
        {
            if (SelectedDev.GooglePlus != null)
            {
                var google_dev = "http://plus.google.com/" + SelectedDev.GooglePlus;
                Device.OpenUri(new Uri(google_dev));
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Google Plus não informado", "Ok");
            }
        }

        private void ButtonGithub_Clicked(object sender, EventArgs e)
        {
            if (SelectedDev.Github != null)
            {
                var github_dev = "http://github.com/" + SelectedDev.Github;
                Device.OpenUri(new Uri(github_dev));
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Github não informado", "Ok");
            }
        }

        private void ButtonFacebook_Clicked(object sender, EventArgs e)
        {
            if(SelectedDev.Facebook != null)
            {
                var facebook_dev = "http://facebook.com/" + SelectedDev.Facebook;
                Device.OpenUri(new Uri(facebook_dev));
            } else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Facebook não informado", "Ok");
            }
            
        }
    }
}
