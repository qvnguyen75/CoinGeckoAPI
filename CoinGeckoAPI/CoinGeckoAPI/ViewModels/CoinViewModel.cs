using CoinGeckoAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGeckoAPI.ViewModels
{
    public class CoinViewModel : ViewModel
    {
        public Coin Item { get; private set; }
        public CoinViewModel(Coin coin) => Item = coin;
    }
}
