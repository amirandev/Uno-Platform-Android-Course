# JSON Serialization

## System.Text.Json

```csharp
using System.Text.Json;

// Serialize
var json = JsonSerializer.Serialize(product);

// Deserialize
var product = JsonSerializer.Deserialize<Product>(json);

// With options
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true
};
```

## JSON Attributes

```csharp
public class User
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; } = "";

    [JsonIgnore]
    public string? TempData { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
}
```

## Handling Dates

```csharp
var options = new JsonSerializerOptions
{
    Converters = { new JsonStringEnumConverter() }
};
```

## Nested Objects

```csharp
public class ApiResponse<T>
{
    public bool Success { get; set; }
    public T? Data { get; set; }
    public string? Error { get; set; }
}

// Usage
var response = JsonSerializer.Deserialize<ApiResponse<List<Product>>>(json);
if (response?.Success == true)
    var products = response.Data;
```

## JSON for Local Storage

```csharp
public static class JsonHelper
{
    public static async Task SaveToFileAsync<T>(string filename, T data)
    {
        var file = await ApplicationData.Current.LocalFolder
            .CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
        var json = JsonSerializer.Serialize(data);
        await FileIO.WriteTextAsync(file, json);
    }

    public static async Task<T?> LoadFromFileAsync<T>(string filename) where T : class
    {
        try
        {
            var file = await ApplicationData.Current.LocalFolder
                .GetFileAsync(filename);
            var json = await FileIO.ReadTextAsync(file);
            return JsonSerializer.Deserialize<T>(json);
        }
        catch { return null; }
    }
}
```

---

**Next:** [Authentication](03-authentication.md)
