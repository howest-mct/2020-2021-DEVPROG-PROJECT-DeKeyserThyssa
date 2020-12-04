using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Models
{
    public class LanguageCountry
    {
        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; }
        [JsonProperty(PropertyName = "NativeName")]
        public String NativeName { get; set; }
    }
}
