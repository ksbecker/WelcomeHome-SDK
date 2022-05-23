using Refit;

namespace WelcomeHome.Sdk
{
    public static class WelcomeHomeApiClientFactory
    {
        public static IWelcomeHomeApiClient Create(HttpClient httpClient, string host, string apiKey)
        {
            httpClient.BaseAddress = new Uri(host);

            ConfigureHttpClient(httpClient, apiKey);

            return RestService.For<IWelcomeHomeApiClient>(httpClient);
        }

        public static IWelcomeHomeApiClient Create(string host, string apiKey) => Create(new HttpClient(), host, apiKey);

        internal static void ConfigureHttpClientCore(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
        }

        private static void ConfigureHttpClient(HttpClient httpClient, string apiKey)
        {
            ConfigureHttpClientCore(httpClient);
            httpClient.AddWelcomeHomeHeaders(apiKey);
        }
    }
}
