# WelcomeHome SDK

[![.NET](https://github.com/ksbecker/WelcomeHome-SDK/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ksbecker/WelcomeHome-SDK/actions/workflows/dotnet.yml)

This is an implementation for the [WelcomeHome REST API](https://crm.welcomehomesoftware.com/api-docs/index.html).

This is not a complete implementation, but if you ask, maybe I'll update it to
include more/all of the endpoints.

### Register during startup

```csharp
builder.Services.AddTransient<AuthHeaderHandler>();
builder.Services
    .AddWelcomeHomeApiClient(httpClient =>
    {
        var host = builder.Configuration["WelcomeHomeClient:host"];

        httpClient.BaseAddress = new Uri(host);
    })
    .AddHttpMessageHandler<AuthHeaderHandler>();
```

### Usage

```csharp
private readonly IWelcomeHomeApiClient _welcomeHomeApiClient;

_welcomeHomeApiClient.TraitsAsync(account.ApiKey!).Result;
```

I made the API Key dynamic as I have multiple accounts that need to be run against.