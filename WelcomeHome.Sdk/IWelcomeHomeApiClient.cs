using System.Runtime.Serialization;

using Refit;

using WelcomeHome.Sdk.Models;

namespace WelcomeHome.Sdk;

public interface IWelcomeHomeApiClient
{
    [Get("/exports/community/{id}/table/{table}")]
    Task<string> ExportAsync([AliasAs("id")] int communityId,
                             [AliasAs("table")] Table table,
                             [Authorize("Token")] string authorization,
                             [AliasAs("limit")] int? limit = null,
                             [AliasAs("sort_by")] SortBy sortBy = SortBy.UpdatedAt,
                             [AliasAs("filters[created_at_after]")][Query(Format = "yyyy-MM-ddTHH:mm:ss.fffZ")] DateTimeOffset? createdAtAfterUtc = null,
                             [AliasAs("filters[updated_at_after]")][Query(Format = "yyyy-MM-ddTHH:mm:ss.fffZ")] DateTimeOffset? updatedAtAfterUtc = null,
                             [AliasAs("filters[created_at_before]")][Query(Format = "yyyy-MM-ddTHH:mm:ss.fffZ")] DateTimeOffset? createdAtBeforeUtc = null,
                             [AliasAs("filters[updated_at_before]")][Query(Format = "yyyy-MM-ddTHH:mm:ss.fffZ")] DateTimeOffset? updatedAtBeforeUtc = null,
                             CancellationToken cancellationToken = default);

    [Get("/lead_sources")]
    Task<IEnumerable<ListLeadSourcesResponse>> ListLeadSources([Authorize("Token")] string authorization, CancellationToken cancellationToken = default!);

    [Get("/ping")]
    Task<PingResponse> PingAsync([Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Post("/prospects")]
    Task<ProspectResponse> AddProspectAsync([Body(BodySerializationMethod.UrlEncoded)] ProspectRequest prospectRequest, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Get("/prospects/{id}")]
    Task<ProspectResponse> ShowProspectAsync([AliasAs("id")] int prospectId, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Put("/prospects/{id}")]
    Task<ProspectResponse> UpdateProspectAsync([AliasAs("id")] int prosepctId, [Body(BodySerializationMethod.Serialized)] ProspectRequest prospectRequest, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Put("/residents/{id}")]
    Task<ResidentResponse> UpdateResidentAsync([AliasAs("id")] int residentId, [Body(BodySerializationMethod.Serialized)] ResidentRequest residentRequest, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Get("/traits")]
    Task<IEnumerable<TraitsResponse>> TraitsAsync([Authorize("Token")] string authorization, CancellationToken cancellationToken = default);
}

public enum SortBy
{
    [EnumMember(Value = "updated_at")]
    UpdatedAt,
    [EnumMember(Value = "created_at")]
    CreatedAt,
}

public enum Table
{
    [EnumMember(Value = "Organizations")]
    Organizations,
    [EnumMember(Value = "Referrers")]
    Referrers,
    [EnumMember(Value = "Prospects")]
    Prospects,
    [EnumMember(Value = "Residents")]
    Residents,
    [EnumMember(Value = "Influencers")]
    Influencers,
    [EnumMember(Value = "Activities")]
    Activities,
    [EnumMember(Value = "Units")]
    Units,
    [EnumMember(Value = "HousingContracts")]
    HousingContracts
}