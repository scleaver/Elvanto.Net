using Newtonsoft.Json;
using System.Collections.Generic;

namespace Elvanto.Net.Models
{
    public class GroupCategories
    {
        [JsonProperty("category")]
        public List<Category> Category { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
