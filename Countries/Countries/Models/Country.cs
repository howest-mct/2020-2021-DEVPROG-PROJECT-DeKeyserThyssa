using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Models
{
    public class Country
    {
        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; }
        [JsonProperty(PropertyName = "capital")]
        public String Capital { get; set; }
        [JsonProperty(PropertyName = "region")]
        public String Region { get; set; }
        [JsonProperty(PropertyName = "subregion")]
        public String Subregion { get; set; }
        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }
        [JsonProperty(PropertyName = "latlng")]
        public List<decimal> Lating { get; set; }
        [JsonProperty(PropertyName = "timezones")]
        public List<String> Timezones { get; set; }
        [JsonProperty(PropertyName = "borders")]
        public List<String> Borders { get; set; }
        //[JsonProperty(PropertyName = "currencies")]
        //public String Currencies { get; set; }
        //[JsonProperty(PropertyName = "languages")]
        //public List<String> Languages { get; set; }
        [JsonProperty(PropertyName = "alpha3Code")]
        public String ImgCode { get; set; }

        public List<LanguageCountry> LanguageName { get; set; }

        //public List<CurrencyCountry> Code { get; set; }

        //public String AllLanguages
        //{
        //    get
        //    {
        //        if (LanguageName.Count >= 0)
        //        {
        //            return LanguageName[0];
        //        }
        //        else
        //        {
        //            return "No Languages!";
        //        }
        //    }
        //}

    }
}
