using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Elvanto.Net.Models
{
    public class Demographics
    {
        [JsonProperty("demographic")]
        public List<Demographic> Demographic { get; set; }
    }

    public class Demographic : DemographicBase
    {
        [JsonProperty("sub_demographics")]
        public SubDemographics SubDemographics { get; set; }
    }

    public class SubDemographics
    {
        [JsonProperty("sub_demographic")]
        public List<SubDemographic> SubDemographic { get; set; }
    }

    public class SubDemographic : DemographicBase { }

    public abstract class DemographicBase
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
