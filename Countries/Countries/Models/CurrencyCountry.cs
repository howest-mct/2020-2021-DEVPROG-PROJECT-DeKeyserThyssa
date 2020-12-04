using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Models
{
    public class CurrencyCountry
    {
        [JsonProperty(PropertyName = "code")]
        public String Code { get; set; }
        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; }
        [JsonProperty(PropertyName = "symbol")]
        public String Symbol { get; set; }
    }
}
