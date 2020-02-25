using Elvanto.Net.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Elvanto.Net.Models
{
    public class Group
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public GroupStatus Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("meeting_address")]
        public string MeetingAddress { get; set; }

        [JsonProperty("meeting_city")]
        public string MeetingCity { get; set; }

        [JsonProperty("meeting_state")]
        public string MeetingState { get; set; }

        [JsonProperty("meeting_postcode")]
        public string MeetingPostcode { get; set; }

        [JsonProperty("meeting_country")]
        public string MeetingCountry { get; set; }

        [JsonProperty("meeting_day")]
        public string MeetingDay { get; set; }

        [JsonProperty("meeting_time")]
        public string MeetingTime { get; set; }

        [JsonProperty("meeting_frequency")]
        public string MeetingFrequency { get; set; }

        [JsonProperty("people")]
        [JsonConverter(typeof(SingleOrArrayConverter<People>))]
        public List<People> People { get; set; }

        [JsonProperty("locations")]
        [JsonConverter(typeof(SingleOrArrayConverter<Locations>))]
        public IEnumerable<Locations> Locations { get; set; }

        [JsonProperty("demographics")]
        [JsonConverter(typeof(SingleOrArrayConverter<Demographics>))]
        public List<Demographics> Demographics { get; set; }

        [JsonProperty("categories")]
        [JsonConverter(typeof(SingleOrArrayConverter<GroupCategories>))]
        public List<GroupCategories> Categories { get; set; }
    }

    public class People
    {
        [JsonProperty("person")]
        public List<Person> Person { get; set; }
    }

    public enum GroupStatus
    {
        Active,
        Suspended
    }
}
