using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core
{
    public class QueryableBaseRequest : BaseRequest
    {
        private int _page = 1;

        [JsonProperty("page")]
        public int Page { get => _page; set => _page = value; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }
    }
}
