using Newtonsoft.Json;

namespace Elvanto.Net.Core
{
    public abstract class BaseResponse
    {

        [JsonProperty("generated_in")]
        public double GeneratedIn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
