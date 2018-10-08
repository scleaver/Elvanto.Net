using Elvanto.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core.Responses
{
    public class PersonResponse : BaseResponse
    {
        public PersonResponse()
        {
            People = new HashSet<Person>();
        }

        [JsonProperty("person")]
        public IEnumerable<Person> People { get; set; }
    }
}
