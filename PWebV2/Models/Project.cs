using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PWebV2.Models
{
    public class Project
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "project_source")]
        public string ProjectSource { get; set; }
        
        [JsonProperty(PropertyName = "project_link")]
        public string ProjectLink { get; set; }

        [JsonProperty(PropertyName = "Img_name")]
        public string Image { get; set; }
    }
}
