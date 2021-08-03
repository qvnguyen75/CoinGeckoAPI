using CoinGeckoAPI.Models;
using CoinGeckoAPI.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGeckoAPI.ViewModels
{
    public class DetailViewModel : ViewModel
    {
        public readonly RestService restService;

        public DetailViewModel(RestService restService)
        {
            this.restService = restService;
            Console.WriteLine("TEST CONSTRUCTOR");
        }

        public Coin Item { get; set; }
    }
}
