using CoinGeckoAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoinGeckoAPI.Services
{
    public class RestService : IRestService
    {

        HttpClient client;
        private string Base_Url = "https://api.coingecko.com/api/v3/";


        public RestService()
        {
            client = new HttpClient();

        }

        public async Task<ObservableCollection<Coin>> GetAllAsync(string currency)
        {
            try
            {
                Uri uri = new Uri(Base_Url + $"/coins/markets?vs_currency={currency}&order=market_cap_desc&per_page=100&page=1&sparkline=false");
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var json = JsonConvert.DeserializeObject<ObservableCollection<Coin>>(result);
                    return json;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("SOMETHING WENT WRONG" + e);
            }
            return null;
        }

        public async void GetPing()
        {
            try
            {
                Uri uri = new Uri(Base_Url + "ping");
                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var json = JsonConvert.DeserializeObject(content);
                    Console.WriteLine(json);
                }
            }
            catch
            {
                Console.WriteLine("SOMETHING WENT WRONG");
            }


        }

     
    }
}
