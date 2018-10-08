using Elvanto.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core.Responses
{
    public class GroupResponse : BaseResponse
    {
        public GroupResponse()
        {
            Groups = new HashSet<Group>();
        }

        [JsonProperty("group")]
        public IEnumerable<Group> Groups { get; set; }
    }
}
