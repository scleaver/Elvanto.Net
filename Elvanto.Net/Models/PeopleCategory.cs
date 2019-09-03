using Newtonsoft.Json;
using System;

namespace Elvanto.Net.Models
{
    public class PeopleCategory
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
