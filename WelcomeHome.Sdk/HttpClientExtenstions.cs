namespace WelcomeHome.Sdk
{
    public static class HttpClientExtenstions
    {
        public static HttpClient AddWelcomeHomeHeaders(this HttpClient httpClient, string apiKey)
        {
            var headers = httpClient.DefaultRequestHeaders;

            headers.Add("Authorization", $"Token token={apiKey}");

            return httpClient;
        }
    }
}
