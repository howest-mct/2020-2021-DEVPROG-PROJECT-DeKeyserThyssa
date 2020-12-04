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
        [JsonProperty(PropertyName = "lating")]
        public float Lating { get; set; }
        [JsonProperty(PropertyName = "timezones")]
        public List<String> Timezones { get; set; }
        [JsonProperty(PropertyName = "borders")]
        public List <String> Borders { get; set; }
        //[JsonProperty(PropertyName = "currencies")]
        //public String Currencies { get; set; }
        //[JsonProperty(PropertyName = "languages")]
        //public String Languages { get; set; }
        //[JsonProperty(PropertyName = "flag")]
        [JsonProperty(PropertyName = "alpha3Code")]
        public String ImgCode { get; set; }
    }
}
