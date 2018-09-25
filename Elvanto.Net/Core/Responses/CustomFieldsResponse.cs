using Elvanto.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core.Responses
{
    public class CustomFieldsResponse : BaseResponse
    {
        [JsonProperty("custom_fields")]
        public CustomFieldsData CustomFieldsData { get; set; }
    }

    public class CustomFieldsData : BaseDataSet
    {
        public CustomFieldsData()
        {
            CustomFields = new HashSet<CustomField>();
        }

        [JsonProperty("custom_field")]
        public IEnumerable<CustomField> CustomFields { get; set; }
    }
}
