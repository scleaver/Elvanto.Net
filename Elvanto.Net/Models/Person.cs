using Newtonsoft.Json;
using System;

namespace Elvanto.Net.Models
{
    public class Person
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }

        [JsonProperty("category_id")]
        public Guid CategoryId { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("admin")]
        public long Admin { get; set; }

        [JsonProperty("archived")]
        public long Archived { get; set; }

        [JsonProperty("contact")]
        public long Contact { get; set; }

        [JsonProperty("volunteer")]
        public long Volunteer { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("last_login")]
        public string LastLogin { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("family_id")]
        public long FamilyId { get; set; }

        [JsonProperty("family_relationship")]
        public string FamilyRelationship { get; set; }

        [JsonProperty("birthday")]
        public DateTimeOffset Birthday { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

    }
}
