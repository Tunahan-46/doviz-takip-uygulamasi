using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DovizKurTakip.Services
{
    public static class KurServisi
    {
        private const string apiUrl = "https://open.er-api.com/v6/latest/{0}";

        public static async Task<Dictionary<string, decimal>> KurGetirAsync(string baseCurrency)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = string.Format(apiUrl, baseCurrency);
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"API erişim hatası: HTTP {(int)response.StatusCode}");

                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ExchangeRateResponse>(json);

                if (data == null || data.Result != "success" || data.Rates == null)
                    throw new Exception("API'den geçerli kur alınamadı.");

                return data.Rates;
            }
        }

        private class ExchangeRateResponse
        {
            [JsonProperty("result")] public string Result { get; set; }
            [JsonProperty("rates")] public Dictionary<string, decimal> Rates { get; set; }
        }
    }
}
