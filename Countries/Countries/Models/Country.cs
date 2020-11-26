using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Models
{
    public class Country
    {
        public String Name { get; set; }
        public String Capital { get; set; }
        public String Region { get; set; }
        public String Subregion { get; set; }
        public int Population { get; set; }
        public float Lating { get; set; }
        public String Timezones { get; set; }
        public String Borders { get; set; }
        public String Currencies { get; set; }
        public String Languages { get; set; }
        public object Flag { get; set; }
    }
}
