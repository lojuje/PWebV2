using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PWebV2.Models
{
    public class About
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "info1")]
        public string Info1 { get; set; }

        [JsonProperty(PropertyName = "info2")]
        public string Info2 { get; set; }

        [JsonProperty(PropertyName = "resume_link")]
        public string Resume { get; set; }

        //[JsonProperty(PropertyName = "About_Img")]
        //public string AboutImg { get; set; }

    }
}
