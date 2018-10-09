using Newtonsoft.Json;

namespace Elvanto.Net.Core
{
    public class QueryableBaseRequest : BaseRequest
    {

        [JsonProperty("page")]
        public int Page { get; set; } = 1;
        [JsonProperty("page_size")]
        public int PageSize { get; set; } = 1000;
    }
}
