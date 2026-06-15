# REST API Client

## HttpClient Setup

```csharp
public class ApiClient
{
    private readonly HttpClient _http;

    public ApiClient()
    {
        _http = new HttpClient
        {
            BaseAddress = new Uri("https://api.example.com"),
            Timeout = TimeSpan.FromSeconds(30)
        };
        _http.DefaultRequestHeaders.Add("Accept", "application/json");
    }
}
```

## GET Request

```csharp
public async Task<List<Product>> GetProductsAsync()
{
    var response = await _http.GetAsync("/api/products");
    response.EnsureSuccessStatusCode();
    var json = await response.Content.ReadAsStringAsync();
    return JsonSerializer.Deserialize<List<Product>>(json) ?? new();
}
```

## POST Request

```csharp
public async Task<Product> CreateProductAsync(Product product)
{
    var json = JsonSerializer.Serialize(product);
    var content = new StringContent(json, Encoding.UTF8, "application/json");
    var response = await _http.PostAsync("/api/products", content);
    response.EnsureSuccessStatusCode();
    var result = await response.Content.ReadAsStringAsync();
    return JsonSerializer.Deserialize<Product>(result)!;
}
```

## Error Handling

```csharp
public async Task<Result<List<Product>>> SafeGetProductsAsync()
{
    try
    {
        var products = await GetProductsAsync();
        return Result.Success(products);
    }
    catch (HttpRequestException ex)
    {
        return Result.Fail<List<Product>>("Network error. Check connection.");
    }
    catch (TaskCanceledException)
    {
        return Result.Fail<List<Product>>("Request timed out.");
    }
    catch (Exception ex)
    {
        return Result.Fail<List<Product>>($"Unexpected error: {ex.Message}");
    }
}
```

## Result Pattern

```csharp
public class Result<T>
{
    public bool IsSuccess { get; private set; }
    public T? Data { get; private set; }
    public string? Error { get; private set; }

    public static Result<T> Success(T data) => new() { IsSuccess = true, Data = data };
    public static Result<T> Fail(string error) => new() { IsSuccess = false, Error = error };
}
```

## Using in ViewModel

```csharp
async Task LoadAsync()
{
    var result = await _api.SafeGetProductsAsync();
    if (result.IsSuccess)
    {
        Products.Clear();
        foreach (var p in result.Data!) Products.Add(p);
    }
    else
    {
        ErrorMessage = result.Error;
    }
}
```

---

**Next:** [Module 8 — Networking](../08-networking/01-http-requests.md)
