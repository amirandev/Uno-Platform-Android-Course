# Authentication

## JWT Token Auth

```csharp
public class AuthService
{
    private readonly HttpClient _http;
    private string? _token;

    public AuthService(HttpClient http) => _http = http;

    public async Task<bool> LoginAsync(string username, string password)
    {
        var payload = new { username, password };
        var response = await _http.PostAsync("/auth/login",
            payload.ToJsonContent());
        if (!response.IsSuccessStatusCode) return false;

        var result = await response.Content.ReadAsync<LoginResponse>();
        _token = result?.Token;
        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", _token);
        await SecureStorage.SetAsync("auth_token", _token);
        return true;
    }

    public async Task<bool> TryRestoreSessionAsync()
    {
        var token = await SecureStorage.GetAsync("auth_token");
        if (string.IsNullOrEmpty(token)) return false;
        _token = token;
        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", _token);
        return true;
    }

    public void Logout()
    {
        _token = null;
        _http.DefaultRequestHeaders.Authorization = null;
        SecureStorage.Remove("auth_token");
    }
}
```

## Token Interceptor

```csharp
public class AuthHttpMessageHandler : DelegatingHandler
{
    private readonly ISecureStorage _storage;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken ct)
    {
        var token = await _storage.GetAsync("auth_token");
        if (!string.IsNullOrEmpty(token))
            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

        var response = await base.SendAsync(request, ct);

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            // Token expired — redirect to login
            // Use Messaging or Navigation
        }

        return response;
    }
}

// Register
services.AddTransient<AuthHttpMessageHandler>();
services.AddHttpClient<IUserApi, UserApi>()
    .AddHttpMessageHandler<AuthHttpMessageHandler>();
```

## OAuth / Social Login

Use WebAuthenticationBroker or platform-specific OAuth libraries. On Android, you'll use Android Intents.

---

**Next:** [Real-time Communication](04-real-time-communication.md)
