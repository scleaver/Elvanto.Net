using Newtonsoft.Json;
using System.Collections.Generic;
using static Elvanto.Net.Core.Enums;

namespace Elvanto.Net.Core.Requests
{
    public class GroupsRequest : QueryableBaseRequest
    {

        [JsonProperty("category_id")]
        public List<string> CategoryIds { get; set; }

        [JsonProperty("suspended")]
        public SuspendedStatus Suspended { get; set; }
    }
}
