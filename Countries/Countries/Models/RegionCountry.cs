using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Models
{
    public class RegionCountry
    {
        [JsonProperty(PropertyName = "region")]
        public String Name { get; set; }
    }
}
