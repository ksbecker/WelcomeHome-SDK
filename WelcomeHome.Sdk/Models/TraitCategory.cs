using Newtonsoft.Json;

namespace WelcomeHome.Sdk.Models
{
    public class TraitCategory
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; } = default!;
    }
}
