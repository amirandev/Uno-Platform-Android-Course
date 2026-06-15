# Settings & Preferences

## Using Preferences API

Uno provides a cross-platform `Preferences` API (uno-port of MAUI Essentials):

```csharp
// Save
Preferences.Set("username", "alice");
Preferences.Set("volume", 0.8);
Preferences.Set("isDarkMode", true);

// Read with default
var name = Preferences.Get("username", "");
var vol = Preferences.Get("volume", 0.5);
var dark = Preferences.Get("isDarkMode", false);

// Remove
Preferences.Remove("username");

// Check exists
var hasKey = Preferences.ContainsKey("username");

// Clear all
Preferences.Clear();
```

## Settings Service

```csharp
public interface ISettingsService
{
    string? UserName { get; set; }
    bool IsDarkMode { get; set; }
    double Volume { get; set; }
}

public class SettingsService : ISettingsService
{
    public string? UserName
    {
        get => Preferences.Get("username", null);
        set => Preferences.Set("username", value);
    }

    public bool IsDarkMode
    {
        get => Preferences.Get("darkmode", false);
        set => Preferences.Set("darkmode", value);
    }

    public double Volume
    {
        get => Preferences.Get("volume", 0.5);
        set => Preferences.Set("volume", value);
    }
}
```

## Encrypted Storage (Secure)

For sensitive data like tokens:

```csharp
// Use SecureStorage cross-platform
var token = await SecureStorage.GetAsync("auth_token");
await SecureStorage.SetAsync("auth_token", "eyJ...");
```

---

**Next:** [File Storage](02-file-storage.md)
