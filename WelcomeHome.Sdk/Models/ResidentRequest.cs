using Newtonsoft.Json;

namespace WelcomeHome.Sdk.Models
{
    public class ResidentRequest
    {
        [JsonProperty(PropertyName = "resident")]
        public Resident Resident { get; set; } = default!;
    }

    public class Resident
    {
        [JsonProperty(PropertyName = "care_type_id")]
        public int? CareTypeId { get; set; }

        [JsonProperty(PropertyName = "marital_status")]
        public string? MaritalStatus { get; set; }

        [JsonProperty(PropertyName = "person_attributes")]
        public Person_Attributes? PersonAttributes { get; set; }
    }
}
