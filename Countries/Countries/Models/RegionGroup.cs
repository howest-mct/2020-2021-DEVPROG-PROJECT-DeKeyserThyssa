using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Models
{
    public class RegionGroup
    {
        [JsonProperty(PropertyName = "region")]
        public String Region { get; set; }
    }
}
