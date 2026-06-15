# Async & Await

## Why Async Matters on Mobile

- **Network calls** — Fetching data from APIs
- **Database ops** — SQLite read/write
- **File I/O** — Reading images, saving files
- **UI thread** — Never block the main thread (= frozen app)

## Basic Pattern

```csharp
// Method signature
async Task<string> FetchDataAsync()
{
    using var client = new HttpClient();
    return await client.GetStringAsync("https://api.example.com/data");
}

// Call it (must be in an async context)
var data = await FetchDataAsync();
```

## Async in Event Handlers

```csharp
async void OnLoginClick(object sender, RoutedEventArgs e)
{
    LoginButton.IsEnabled = false;
    try
    {
        var result = await LoginService.LoginAsync(username, password);
        Frame.Navigate(typeof(HomePage));
    }
    catch (Exception ex)
    {
        await DialogService.ShowErrorAsync(ex.Message);
    }
    finally
    {
        LoginButton.IsEnabled = true;
    }
}
```

## Async Methods on Mobile

```csharp
// Show dialog
var result = await new ContentDialog { Title = "Confirm", Content = "Proceed?" }
    .ShowAsync();

// Request permission
var status = await Permissions.RequestAsync<Permissions.Location>();

// Pick file
var file = await FilePicker.PickAsync(new PickOptions());
```

## Error Handling

```csharp
try
{
    var data = await riskyOperation();
}
catch (HttpRequestException) when (data == null)
{
    // Network error
}
catch (TaskCanceledException)
{
    // Timeout
}
catch (Exception ex)
{
    // Log and show generic error
    Debug.WriteLine($"Error: {ex}");
}
```

---

**Next:** [Null Safety](06-null-safety.md)
