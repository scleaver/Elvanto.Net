using Elvanto.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core.Responses
{
    public class PeopleResponse : BaseResponse
    {
        [JsonProperty("people")]
        public PeopleData PeopleData { get; set; }
    }

    public class PeopleData : BaseDataSet
    {
        public PeopleData()
        {
            People = new HashSet<Person>();
        }

        [JsonProperty("person")]
        public IEnumerable<Person> People { get; set; }
    }
}
