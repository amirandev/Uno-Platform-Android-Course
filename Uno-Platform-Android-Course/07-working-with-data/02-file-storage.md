# File Storage

## App Data Directories

```csharp
// App-specific folders
var localFolder = ApplicationData.Current.LocalFolder;     // Persistent
var tempFolder = ApplicationData.Current.TemporaryFolder;  // Can be cleared
var cacheFolder = ApplicationData.Current.LocalCacheFolder; // Cache

// Path example
var dbPath = Path.Combine(localFolder.Path, "myapp.db");
var logPath = Path.Combine(cacheFolder.Path, "logs");
```

## Reading & Writing Files

```csharp
// Text
await FileIO.WriteTextAsync(file, "Hello World");
var text = await FileIO.ReadTextAsync(file);

// Binary
await FileIO.WriteBytesAsync(file, new byte[] { 1, 2, 3 });
var bytes = await FileIO.ReadBytesAsync(file);

// Buffer
await FileIO.WriteBufferAsync(file, buffer);
```

## Working with StorageFile

```csharp
// Create/Get file
var file = await localFolder.CreateFileAsync("data.json",
    CreationCollisionOption.ReplaceExisting);

// Write
await FileIO.WriteTextAsync(file, jsonContent);

// Read
file = await localFolder.GetFileAsync("data.json");
var content = await FileIO.ReadTextAsync(file);

// Delete
await file.DeleteAsync();
```

## JSON Serialization

```csharp
public static class JsonStorage
{
    public static async Task SaveAsync<T>(string key, T data)
    {
        var file = await ApplicationData.Current.LocalFolder
            .CreateFileAsync($"{key}.json",
                CreationCollisionOption.ReplaceExisting);
        var json = JsonSerializer.Serialize(data);
        await FileIO.WriteTextAsync(file, json);
    }

    public static async Task<T?> LoadAsync<T>(string key) where T : class
    {
        var file = await ApplicationData.Current.LocalFolder
            .TryGetItemAsync($"{key}.json");
        if (file is null) return null;
        var json = await FileIO.ReadTextAsync((StorageFile)file);
        return JsonSerializer.Deserialize<T>(json);
    }
}
```

---

**Next:** [SQLite Database](03-sqlite-database.md)
