
using Newtonsoft.Json;

namespace WelcomeHome.Sdk.Models;

public class ListLeadSourcesResponse
{
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; } = default!;

    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; } = default!;

    [JsonProperty(PropertyName = "discarded_at")]
    public DateTime? DiscardedAt { get; set; }

    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }
}