using CoinGeckoAPI.Models;

using CoinGeckoAPI.Services;
using CoinGeckoAPI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoinGeckoAPI.ViewModels
{
    public class MainViewModel : ViewModel
    {

        private readonly RestService _restService;
        public event EventHandler<TextChangedEventArgs> TextChanged;
        public ObservableCollection<Coin> Coins { get; set; }

        public MainViewModel(RestService restService)
        {
                
            _restService = restService;          
            Task.Run(async () => await LoadData());
            _restService.GetPing();
           
        }
        private async Task LoadData()
        {        
            var coins = await _restService.GetAllAsync("usd");
                      
            Coins = new ObservableCollection<Coin>(coins);
           
        }

        public Coin SelectedItem
        {

            get { return null; }
            set
            {
               
                Device.BeginInvokeOnMainThread(async () => await NavigateToItem(value));
                RaisePropertyChanged(nameof(SelectedItem));
            }
        }

        private async Task NavigateToItem(Coin item)
        {

            if (item == null)
            {
                return;
            }

            var detailView = Resolver.Resolve<DetailView>();
            var vm = detailView.BindingContext as DetailViewModel;
            vm.Item = item;

            await Navigation.PushAsync(detailView);
        }

     
    }
}
