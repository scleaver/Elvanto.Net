using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Models
{
    public class CustomField
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public ValuesData Values { get; set; }
    }

    public class ValuesData
    {
        [JsonProperty("value")]
        public List<CustomFieldValues> Value { get; set; }
    }

    public class CustomFieldValues
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
