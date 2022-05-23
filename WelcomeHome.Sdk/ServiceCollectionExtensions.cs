
using Microsoft.Extensions.DependencyInjection;

using Refit;

namespace WelcomeHome.Sdk
{
    public static class ServiceCollectionExtensions
    {
        public static IHttpClientBuilder AddWelcomeHomeApiClient(this IServiceCollection services, Action<HttpClient> configureClient)
        {
            var settings = new RefitSettings(new NewtonsoftJsonContentSerializer());

            return services.AddRefitClient<IWelcomeHomeApiClient>(settings)
                .ConfigureHttpClient((httpClient) =>
                {
                    WelcomeHomeApiClientFactory.ConfigureHttpClientCore(httpClient);
                    configureClient(httpClient);
                });
        }
    }
}
