using Refit;

using WelcomeHome.Sdk.Models;

namespace WelcomeHome.Sdk;

public interface IWelcomeHomeApiClient
{
    [Get("/ping")]
    Task<PingResponse> PingAsync([Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Get("/traits")]
    Task<IEnumerable<TraitsResponse>> TraitsAsync([Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Post("/prospects")]
    Task<ProspectResponse> AddProspectAsync([Body(BodySerializationMethod.UrlEncoded)] ProspectRequest prospectRequest, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Get("/prospects/{id}")]
    Task<ProspectResponse> ShowProspectAsync([AliasAs("id")] int prospectId, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Put("/prospects/{id}")]
    Task<ProspectResponse> UpdateProspectAsync([AliasAs("id")] int prosepctId, [Body(BodySerializationMethod.Serialized)] ProspectRequest prospectRequest, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);

    [Put("/residents/{id}")]
    Task<ResidentResponse> UpdateResidentAsync([AliasAs("id")] int residentId, [Body(BodySerializationMethod.Serialized)] ResidentRequest residentRequest, [Authorize("Token")] string authorization, CancellationToken cancellationToken = default);
}
