using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core
{
    public class SingleItemRequest : BaseRequest
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
