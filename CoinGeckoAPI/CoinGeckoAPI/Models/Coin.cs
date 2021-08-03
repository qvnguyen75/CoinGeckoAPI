using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CoinGeckoAPI.Models
{
    public class Coin
    {
      
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Current_price { get; set; }
        public long Market_cap { get; set; }
        public int Market_cap_rank { get; set; }
        public long? Fully_diluted_valuation { get; set; }
        public long Total_volume { get; set; }
        public string High_24h { get; set; }
        public string Low_24h { get; set; }
        public double Price_change_24h { get; set; }
        public double Price_change_percentage_24h { get; set; }
        public long Market_cap_change_24h { get; set; }
        public double Market_cap_change_percentage_24h { get; set; }
        public string Circulating_supply { get; set; }
        public double? Total_supply { get; set; }
        public string Max_supply { get; set; }
        public string Ath { get; set; }
        public double Ath_change_percentage { get; set; }
        public DateTime Ath_date { get; set; }
        public double Atl { get; set; }
        public double Atl_change_percentage { get; set; }
        public DateTime Atl_date { get; set; }
        public DateTime Last_updated { get; set; }
    }

}
