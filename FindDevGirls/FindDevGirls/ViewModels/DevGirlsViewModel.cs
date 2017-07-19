using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using FindDevGirls.Models;
using Xamarin.Forms;

namespace FindDevGirls.ViewModels
{
    public class DevGirlsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool Busy;

        public ObservableCollection<DevGirl> DevGirls { get; set; }

        public Command GetsDevGirlsCommand { get; set; }

        private void onPropertyChanged([System.Runtime.CompilerServices.CallerMemberName]
                                        string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public bool IsBusy
        {
            get
            {
                return Busy;
            }

            set
            {
                Busy = value;
                onPropertyChanged();
                GetsDevGirlsCommand.ChangeCanExecute();
            }
        }

        public DevGirlsViewModel()
        {
            DevGirls = new ObservableCollection<DevGirl>();

            GetsDevGirlsCommand = new Command(
                async () => await GetDevGirls(),
                () => !IsBusy);
        }

        async Task GetDevGirls()
        {
            if (!IsBusy)
            {
                Exception Error = null;
                try
                {
                    IsBusy = true;
                    var Repository = new Repository();
                    var Items = await Repository.GetDevGirls();

                    DevGirls.Clear();
                    foreach(var Girl in Items)
                    {
                        DevGirls.Add(Girl);
                    }

                } catch(Exception ex)
                {
                    Error = ex;
                }
                finally
                {
                    IsBusy = false;

                    if(Error != null)
                    {
                        await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error!", Error.Message, "Ok");
                    }
                }

            }

            return;
        }
    }
}
