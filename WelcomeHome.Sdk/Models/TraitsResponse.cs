using Newtonsoft.Json;

namespace WelcomeHome.Sdk.Models
{
    public class TraitsResponse
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; } = default!;

        [JsonProperty(PropertyName = "trait_category")]
        public TraitCategory TraitCategory { get; set; } = default!;

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; } = default!;

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; } = default!;
    }
}
