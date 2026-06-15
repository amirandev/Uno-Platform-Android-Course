# HTTP Requests & Networking

## Making HTTP Requests

```csharp
using var client = new HttpClient();

// GET
var response = await client.GetAsync("https://api.example.com/users");
var content = await response.Content.ReadAsStringAsync();

// POST
var payload = JsonSerializer.Serialize(new User { Name = "Alice" });
var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");
var postResponse = await client.PostAsync("https://api.example.com/users", httpContent);

// PUT
var putResponse = await client.PutAsync($"https://api.example.com/users/{id}", httpContent);

// DELETE
var deleteResponse = await client.DeleteAsync($"https://api.example.com/users/{id}");
```

## Typed Client

```csharp
public interface IUserApi
{
    Task<List<User>> GetUsersAsync();
    Task<User> GetUserAsync(int id);
    Task<User> CreateUserAsync(User user);
}

public class UserApi : IUserApi
{
    private readonly HttpClient _http;

    public UserApi(HttpClient http) => _http = http;

    public async Task<List<User>> GetUsersAsync()
    {
        var response = await _http.GetAsync("/users");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsync<List<User>>();
    }
    // ...
}
```

## Extension Methods

```csharp
public static class HttpExtensions
{
    public static async Task<T?> ReadAsync<T>(this HttpContent content)
    {
        var json = await content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }

    public static StringContent ToJsonContent<T>(this T data)
        => new(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
}
```

## Polly Retry

```csharp
// Install Polly NuGet
var retryPolicy = Policy
    .Handle<HttpRequestException>()
    .WaitAndRetryAsync(3, retryAttempt =>
        TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

await retryPolicy.ExecuteAsync(async () =>
{
    var response = await _http.GetAsync("/fragile-endpoint");
    response.EnsureSuccessStatusCode();
});
```

## Connectivity Check

```csharp
// Uno doesn't have built-in connectivity check
// Use native or simple ping
try
{
    using var client = new HttpClient();
    client.Timeout = TimeSpan.FromSeconds(5);
    var response = await client.GetAsync("https://www.google.com");
    return response.IsSuccessStatusCode;
}
catch
{
    return false;
}
```

---

**Next:** [JSON Serialization](02-json-serialization.md)
