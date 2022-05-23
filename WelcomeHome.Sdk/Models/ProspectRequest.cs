using Newtonsoft.Json;

namespace WelcomeHome.Sdk.Models
{
    public class ProspectRequest
    {
        [JsonProperty(PropertyName = "prospect")]
        public Prospect Prospect { get; set; } = default!;
    }

    public class Prospect
    {
        [JsonProperty(PropertyName = "influencers_attributes")]
        public Influencers_Attributes[]? InfluencersAttributes { get; set; } = default!;

        //[JsonProperty(PropertyName = "lead_source_id")]
        //public int? LeadSourceId { get; set; }

        //[JsonProperty(PropertyName = "secondary_lead_source_id")]
        //public int? SecondaryLeadSourceId { get; set; }

        //[JsonProperty(PropertyName = "notes")]
        //public string? Notes { get; set; }

        //[JsonProperty(PropertyName = "referrer_id")]
        //public int? ReferrerId { get; set; }

        [JsonProperty(PropertyName = "trait_ids")]
        public int[]? TraitIds { get; set; }
    }
}
