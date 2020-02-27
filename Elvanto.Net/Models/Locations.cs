using Newtonsoft.Json;
using System.Collections.Generic;

namespace Elvanto.Net.Models
{
    public class Locations
    {
        [JsonProperty("location")]
        public List<Location> Location { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
