using Newtonsoft.Json;
using System.Collections.Generic;

namespace Homework.Currency.Provider
{
	public class ListOfCurrency
	{
		[JsonProperty("data")]
		public List<Currency> CurrenciesData { get; set; }
	}
		public class Currency
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("rank")]
		public int Rank { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("symbol")]
		public string Symbol { get; set; }
	}
}
