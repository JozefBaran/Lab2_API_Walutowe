using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using ApiWalutowe;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Podaj date w formacie RRRR-MM-DD");
        string? data = Console.ReadLine();

        string format = "rrrr-MM-dd";

        bool isDateValid = DateTime.TryParseExact(data, format, null, System.Globalization.DateTimeStyles.None, out _);
        if (isDateValid)
        {
            Console.WriteLine("Valid data. Try again.");
        }
        else
        {
            Console.WriteLine("Data została podana w prawidłowym formacie.");
        }

        var appId = "17c45a9d1b0a4d34acda9363b66acaae";
        var url = $"https://openexchangerates.org/api/historical/{data}.json?app_id={appId}";


        using (var Client = new HttpClient())
        {
            try
            {
                var response = await Client.GetStringAsync(url);
                Console.WriteLine(response);
                var exchangeRates = JsonSerializer.Deserialize<ExchangeRatesResponse>(response);
                exchangeRates.Date = data;
                Console.WriteLine(exchangeRates.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}