using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenewAutomation.Data_Models
{
    public class Comments
    {
        [JsonProperty("postId")]
        public long postId { get; set; }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("body")]
        public string body { get; set; }
    }
}
