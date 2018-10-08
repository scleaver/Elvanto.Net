using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Models
{
    public class ElvantoApiError
    {
        [JsonProperty("generated_in")]
        public double GeneratedIn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public ElvantoError Error { get; set; }
    }
    public class ElvantoError
    {
        [JsonProperty("code")]
        public int ErrorCode { get; set; }

        [JsonProperty("message")]
        public string ErrorMessage { get; set; }
    }
}
