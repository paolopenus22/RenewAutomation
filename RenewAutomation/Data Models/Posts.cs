using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenewAutomation.Data_Models
{
    public class Posts
    {
        [JsonProperty("userId")]
        public long userId { get; set; }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("body")]
        public string body { get; set; }
    }
}
