using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Elvanto.Net.Core
{
    public abstract class BaseDataSet
    {
        [JsonProperty("on_this_page")]
        public long OnThisPage { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
