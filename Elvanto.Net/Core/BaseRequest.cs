using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core
{
    public class BaseRequest
    {
        public BaseRequest()
        {
            Fields = new List<string>();
        }

        [JsonProperty("fields")]
        public List<string> Fields { get; set; }

    }
}
