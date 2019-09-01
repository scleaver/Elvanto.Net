using Elvanto.Net.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Elvanto.Net.Core.Responses
{
    public class GroupsResponse : BaseResponse
    {
        [JsonProperty("groups")]
        public GroupsData GroupsData { get; set; }
    }

    public class GroupsData : BaseDataSet
    {
        [JsonProperty("group")]
        public IEnumerable<Group> Groups{ get; set; }
    }
}
