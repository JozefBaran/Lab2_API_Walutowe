using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ApiWalutowe
{
    public class ExchangeRatesResponse
    {
       [JsonPropertyName("rates")]
        public Dictionary<string, double> Rates { get; set; }

       [JsonPropertyName("base")]
        public string? Base { get; set; }
        public string? Date { get; set; }

        public ExchangeRatesResponse()
        {
            Rates = new Dictionary<string, double>();
        }
        public override string ToString()
        {   
            double searchingRate = 0;
            if (Rates.TryGetValue("PLN", out searchingRate))
            {
                return $"Dnia {Date} 1 {Base} kosztował {searchingRate} PLN.";
            }
            else
            {
                return $"Dnia {Date} kurs PLN nie jest dostępny dla {Base}.";
            }
        }
    }
}