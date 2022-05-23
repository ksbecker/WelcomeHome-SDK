namespace WelcomeHome.Sdk;

public class AuthHeaderHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Headers.Authorization?.Parameter != null)
        {
            var parameter = request.Headers.Authorization.Parameter;

            request.Headers.Remove("Authorization");
            request.Headers.Add("Authorization", $"Token token={parameter}");
        }

        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}
