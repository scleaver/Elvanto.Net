using Elvanto.Net.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Elvanto.Net.Core.Responses
{
    public class GroupResponse : BaseResponse
    {
        [JsonProperty("group")]
        public IEnumerable<Group> Groups { get; set; }
    }
}
