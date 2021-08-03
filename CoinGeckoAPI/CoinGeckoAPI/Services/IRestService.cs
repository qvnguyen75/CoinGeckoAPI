using CoinGeckoAPI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace CoinGeckoAPI.Services
{
    public interface IRestService
    {  
        Task<ObservableCollection<Coin>> GetAllAsync(string currency);
     

        void GetPing();
    }
}
