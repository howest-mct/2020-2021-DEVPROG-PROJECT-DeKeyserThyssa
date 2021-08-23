using Countries.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
            using (HttpClient client = await GetClient())
            {
                string url = ("https://restcountries.eu/rest/v2/all");
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
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
            using (HttpClient client = await GetClient())
            {
                string url = "https://restcountries.eu/rest/v2/name/{name}";
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
                    List<Country> countryName = JsonConvert.DeserializeObject<List<Country>>(json);
                    return countryName;
                }
                else
                {
                    return null;
                }
            }
        }

        //5: Region opvragen
        public static async Task<List<Country>> GetRegions()
        {
            using (HttpClient client = await GetClient())
            {
                string url = "https://restcountries.eu/rest/v2/all?fields=region";
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
                    List<Country> regionName = JsonConvert.DeserializeObject<List<Country>>(json);
                    return regionName;
                }
                else
                {
                    return null;
                }
            }
        }

        public static async Task<List<Country>> GetListsCountries(String region)
        {
            using (HttpClient client = await GetClient())
            {
                string url = "https://restcountries.eu/rest/v2/all?fields=region"; //zie API
                string json = await client.GetStringAsync(url);
                if (json != null)
                {
                    List<Country> countryLists = JsonConvert.DeserializeObject<List<Country>>(json);
                    return countryLists;
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
