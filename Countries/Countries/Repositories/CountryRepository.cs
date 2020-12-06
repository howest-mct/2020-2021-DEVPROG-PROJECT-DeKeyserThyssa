using Countries.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Repositories
{
    public class CountryRepository
    {
        private static async Task<HttpClient> GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            return httpClient;
        }

        //API gaan communiceren
        // https://restcountries.eu/rest/v2/

        //1: alle countries opvragen
        public async static Task<List<Country>> GetAllCountries()
        {
            //HttpClient nodig --> tussenpersoon die de API-call verzort
            using (HttpClient client = await GetClient())
            {
                string url = ("https://restcountries.eu/rest/v2/all");
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
                    //json --> List<Country>
                    List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(json);
                    return countries;
                }
                else
                {
                    return null;
                }
            }
        }


        //2: Voor één Country de Details gaan opvragen
        public static async Task<List<Country>> GetCountry(String name)
        {
            //HttpClient nodig --> tussenpersoon die de API-call verzort
            using (HttpClient client = await GetClient())
            {
                string url = "https://restcountries.eu/rest/v2/name/{name}";
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
                    //json --> List<Country>
                    List<Country> countryName = JsonConvert.DeserializeObject<List<Country>>(json);
                    return countryName;
                }
                else
                {
                    return null;
                }
            }
        }


        //3: Language opvragen
        public static async Task<List<LanguageCountry>> GetLanguages(String name)
        {
            //HttpClient nodig --> tussenpersoon die de API-call verzort
            using (HttpClient client = await GetClient())
            {
                string url = "https://restcountries.eu/rest/v2/name/{name}";
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
                    //json --> List<Country>
                    List<LanguageCountry> languages = JsonConvert.DeserializeObject<List<LanguageCountry>>(json);
                    return languages;
                }
                else
                {
                    return null;
                }
            }
        }

        //4: Currency opvragen
        public static async Task<List<CurrencyCountry>> GetCurrencies(String name)
        {
            //HttpClient nodig --> tussenpersoon die de API-call verzort
            using (HttpClient client = await GetClient())
            {
                string url = "https://restcountries.eu/rest/v2/name/{name}";
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
                    //json --> List<Country>
                    List<CurrencyCountry> currencies = JsonConvert.DeserializeObject<List<CurrencyCountry>>(json);
                    return currencies;
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
