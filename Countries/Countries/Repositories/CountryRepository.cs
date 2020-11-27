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
                    List<Country> country = JsonConvert.DeserializeObject<List<Country>>(json);
                    return country;
                }
                else
                {
                    return null;
                }
            }
        }



        //public async static Task<List<Country>> GetListsAsync(string region)
        //{
        //    //HttpClient nodig --> tussenpersoon die de API-call verzort
        //    using (HttpClient client = await GetClient())
        //    {
        //        string url = "https://restcountries.eu/rest/v2/name/belgium";
        //        string json = await client.GetStringAsync(url);
        //        if (json != null)
        //        {
        //            //json --> List<Country>
        //            List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(json);
        //            return countries;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}
    }
}
