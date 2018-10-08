using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
        public People People { get; set; }
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
