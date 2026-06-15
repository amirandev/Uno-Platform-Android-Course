# Sharing & Intents

## Share Data

```csharp
public async Task ShareTextAsync(string title, string text)
{
    var dataPackage = new DataPackage();
    dataPackage.SetText(text);
    Clipboard.SetContent(dataPackage);

    // Show toast
    await ShowToastAsync("Copied to clipboard!");
}

public async Task ShareFileAsync(StorageFile file)
{
    var dataPackage = new DataPackage();
    dataPackage.SetBitmap(RandomAccessStreamReference.CreateFromFile(file));
    Clipboard.SetContent(dataPackage);
}
```

## Platform-Specific Sharing (Android Intents)

For full Android share sheet, use platform code:

```csharp
#if __ANDROID__
void ShareOnAndroid(string text)
{
    var intent = new Android.Content.Intent
    {
        Action = Android.Content.Intent.ActionSend
    };
    intent.PutExtra(Android.Content.Intent.ExtraText, text);
    intent.SetType("text/plain");
    var chooser = Android.Content.Intent.CreateChooser(intent, "Share via");
    Android.App.Application.Context.StartActivity(chooser);
}
#endif
```

## Deep Linking (Receiving Intents)

Handle incoming links:

```csharp
// In MainActivity.cs
[IntentFilter(new[] { Intent.ActionView },
    Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
    DataScheme = "myapp", DataHost = "*")]
public class MainActivity : Activity
{
    protected override void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);
        var data = intent?.Data?.ToString();
        // e.g., "myapp://product/42" — navigate user
    }
}
```

## Clipboard

```csharp
// Copy
var dataPackage = new DataPackage();
dataPackage.SetText("Hello");
Clipboard.SetContent(dataPackage);

// Paste
var data = await Clipboard.GetContent();
if (data.Contains(StandardDataFormats.Text))
{
    var text = await data.GetTextAsync();
}
```

---

**Next:** [Module 10 — Advanced Uno](../10-advanced-uno/01-custom-rendering.md)
