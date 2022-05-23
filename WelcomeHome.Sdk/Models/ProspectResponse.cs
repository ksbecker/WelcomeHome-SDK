using Newtonsoft.Json;

namespace WelcomeHome.Sdk.Models
{
    public class ProspectResponse
    {
        [JsonProperty(PropertyName = "account_id")]
        public int AccountId { get; set; }

        [JsonProperty(PropertyName = "active_at")]
        public DateTime? ActiveAt { get; set; }

        [JsonProperty(PropertyName = "close_reason_details")]
        public string CloseReasonDetails { get; set; } = default!;

        [JsonProperty(PropertyName = "close_reason_id")]
        public int? CloseReasonId { get; set; }

        [JsonProperty(PropertyName = "community_id")]
        public int CommunityId { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "discarded_at")]
        public DateTime? DiscardedAt { get; set; }

        [JsonProperty(PropertyName = "discarded_by_id")]
        public int? DiscardedById { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "initial_contact_at")]
        public DateTime? InitialContactAt { get; set; }

        [JsonProperty(PropertyName = "last_contact_at")]
        public DateTime? LastContactAt { get; set; }

        [JsonProperty(PropertyName = "lead_source_id")]
        public int? LeadSourceId { get; set; }

        [JsonProperty(PropertyName = "merged_into_prospect_id")]
        public int? MergedIntoProspectId { get; set; }

        [JsonProperty(PropertyName = "next_activity_scheduled_at")]
        public DateTime? NextActivityScheduledAt { get; set; }

        [JsonProperty(PropertyName = "original_sales_counselor_id")]
        public int? OriginalSalesCounselorId { get; set; }

        [JsonProperty(PropertyName = "referrer_id")]
        public int? ReferrerId { get; set; }

        [JsonProperty(PropertyName = "sales_counselor_id")]
        public int? SalesCounselorId { get; set; }

        [JsonProperty(PropertyName = "secondary_lead_source_id")]
        public int? SecondaryLeadSourceId { get; set; }

        [JsonProperty(PropertyName = "stage_id")]
        public int? StageId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; } = default!;

        [JsonProperty(PropertyName = "status_changed_at")]
        public DateTime? StatusChangedAt { get; set; }

        [JsonProperty(PropertyName = "trait_ids")]
        public int[] TraitIds { get; set; } = default!;

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "residents_attributes")]
        public Residents_Attributes[] ResidentsAttributes { get; set; } = default!;

        [JsonProperty(PropertyName = "influencers_attributes")]
        public Influencers_Attributes[] InfluencersAttributes { get; set; } = default!;
    }

    public class Residents_Attributes
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "person_attributes")]
        public Person_Attributes PersonAttributes { get; set; } = default!;

        //[JsonProperty(PropertyName = "care_type_id")]
        //public int? CareTypeId { get; set; }

        [JsonProperty(PropertyName = "marital_status")]
        public string? MaritalStatus { get; set; }
    }

    public class Person_Attributes
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; } = default!;

        [JsonProperty(PropertyName = "middle_name")]
        public string? MiddleName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string? LastName { get; set; }

        //[JsonProperty(PropertyName = "cell_phone")]
        //public string? CellPhone { get; set; }

        //[JsonProperty(PropertyName = "home_phone")]
        //public string? HomePhone { get; set; }

        //[JsonProperty(PropertyName = "work_phone")]
        //public string? WorkPhone { get; set; }

        //[JsonProperty(PropertyName = "email")]
        //public string? Email { get; set; }

        //[JsonProperty(PropertyName = "fax_number")]
        //public string? FaxNumber { get; set; }

        //[JsonProperty(PropertyName = "do_not_call")]
        //public bool DoNotCall { get; set; }

        //[JsonProperty(PropertyName = "do_not_email")]
        //public bool DoNotEmail { get; set; }

        //[JsonProperty(PropertyName = "do_not_mail")]
        //public bool DoNotMail { get; set; }

        //[JsonProperty(PropertyName = "do_not_text")]
        //public bool DoNotText { get; set; }

        [JsonProperty(PropertyName = "birthdate")]
        public string? Birthdate { get; set; }

        [JsonProperty(PropertyName = "provided_age")]
        public int? ProvidedAge { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string? Gender { get; set; }

        [JsonProperty(PropertyName = "address_attributes")]
        public Address_Attributes AddressAttributes { get; set; } = default!;
    }

    public class Address_Attributes
    {
        [JsonProperty(PropertyName = "line1")]
        public string? Line1 { get; set; }

        [JsonProperty(PropertyName = "line2")]
        public string? Line2 { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string? City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }

        [JsonProperty(PropertyName = "zip")]
        public string? Zip { get; set; }
    }

    public class Influencers_Attributes
    {
        //[JsonProperty(PropertyName = "id")]
        //public int? Id { get; set; }

        [JsonProperty(PropertyName = "person_attributes")]
        public Person_Attributes PersonAttributes { get; set; } = default!;

        //[JsonProperty(PropertyName = "care_type_id")]
        //public int? CareTypeId { get; set; }

        //[JsonProperty(PropertyName = "marital_status")]
        //public string? MaritalStatus { get; set; }
    }
}
