using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PWebV2.Models
{
    public class Home
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Quote")]
        public string Quote { get; set; }

        [JsonProperty(PropertyName = "Img_name")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "Mail")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "Linkedin")]
        public string LinkedIn { get; set; }
        [JsonProperty(PropertyName = "Github")]
        public string Github { get; set; }
    }
}
