using Newtonsoft.Json;

namespace WelcomeHome.Sdk.Models
{
    public class PingResponse
    {
        [JsonProperty(PropertyName = "account_id")]
        public int AccountId { get; init; }

        [JsonProperty(PropertyName = "lead_source_id")]
        public int? LeadSourceId { get; init; }
    }
}
