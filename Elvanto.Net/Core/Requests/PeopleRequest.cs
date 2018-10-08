using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Elvanto.Net.Core.Enums;

namespace Elvanto.Net.Core.Requests
{
    public class PeopleRequest : QueryableBaseRequest
    {
        public PeopleRequest(List<string> categoryIds)
        {
            CategoryIds = new List<string>();
        }

        [JsonProperty("category_id")]
        public List<string> CategoryIds { get; set; }

        [JsonProperty("suspended")]
        public SuspendedStatus Suspended { get; set; }

        [JsonProperty("contact")]
        public ContactStatus Contact { get; set; }

        [JsonProperty("archived")]
        public ArchivedStatus Archived { get; set; }
    }
}
