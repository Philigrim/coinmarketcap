using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace Homework.Currency.ExchangeInfoProvider
{
    public class ExchangeInfoProvider
    {
        private const string c_token = "03689a2f-9fc0-4aa3-8151-a3bd9f04edb6";

        public string GetSecondaryAmount(string PrimaryAmount, string PrimaryCurrencySymbol, string SecondaryCurrencySymbol)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://pro-api.coinmarketcap.com/v1/tools/price-conversion");
                string data = client.GetStringAsync($"?amount={PrimaryAmount}&symbol={PrimaryCurrencySymbol.ToUpper()}&convert={SecondaryCurrencySymbol.ToUpper()}&CMC_PRO_API_KEY={c_token}").Result;
                string price = string.Format("{0:F8}", JObject.Parse(data)["data"]["quote"][SecondaryCurrencySymbol.ToUpper()]["price"]);
                return price;
            }
        }
    }
}
