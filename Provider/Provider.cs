using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Homework.Currency.Provider
{
    public interface CurrenciesListProvider
    {
        ListOfCurrency GetCurrenciesList(string currencyType);
    }

    public class Provider : CurrenciesListProvider
    {
        private const string c_token = "03689a2f-9fc0-4aa3-8151-a3bd9f04edb6";
        public ListOfCurrency GetCurrenciesList(string currencyType)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://pro-api.coinmarketcap.com/v1/");
                string s = client.GetStringAsync(currencyType + "/map?CMC_PRO_API_KEY=" + c_token).Result;
                var list = JsonConvert.DeserializeObject<ListOfCurrency>(s);
                return list;
            }
        }

        public class CashingProvider : CurrenciesListProvider
        {
            private readonly CurrenciesListProvider m_provider;
            private ListOfCurrency m_fiat = null;
            private ListOfCurrency m_crypto = null;
            public CashingProvider(CurrenciesListProvider provider)
            {
                m_provider = provider;
            }
            public ListOfCurrency GetCurrenciesList(string currencyType)
            {
                if(currencyType.Equals("fiat"))
                {
                    if (m_fiat != null)
                    {
                        return m_fiat;
                    }
                    return m_fiat = m_provider.GetCurrenciesList("fiat");
                }
                else
                {
                    if (m_crypto != null)
                    {
                        return m_crypto;
                    }
                    return m_crypto = m_provider.GetCurrenciesList("cryptocurrency");
                }
            }
        }
    }
}
