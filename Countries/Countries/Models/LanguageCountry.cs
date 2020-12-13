using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Models
{
    public class LanguageCountry : IComparable<LanguageCountry>
    {
        [JsonProperty(PropertyName = "name")]
        public String LanguageName { get; set; }

        [JsonProperty(PropertyName = "nativeName")]
        public String NativeName { get; set; }

        public int CompareTo(LanguageCountry other)
        {
            return LanguageName.CompareTo(other.LanguageName);
        }

    }
}
