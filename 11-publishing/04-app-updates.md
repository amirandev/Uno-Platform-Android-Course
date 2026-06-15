# App Updates

## Version Management

```xml
<PropertyGroup>
    <!-- Visible to users -->
    <ApplicationDisplayVersion>1.2.0</ApplicationDisplayVersion>
    <!-- Internal version code (must increase) -->
    <ApplicationVersion>3</ApplicationVersion>
</PropertyGroup>
```

## Update Checklist

- [ ] Increment `ApplicationVersion` and `ApplicationDisplayVersion`
- [ ] Build new signed AAB
- [ ] Test on device
- [ ] Upload to Play Console
- [ ] Roll out to existing testers first
- [ ] Monitor crash reports

## In-App Update Check

```csharp
public class UpdateService
{
    public async Task CheckForUpdateAsync()
    {
        var currentVersion = Package.Current.Id.Version;
        var latestVersion = await _api.GetLatestVersionAsync();

        if (latestVersion > currentVersion)
        {
            var dialog = new ContentDialog
            {
                Title = "Update Available",
                Content = $"Version {latestVersion} is available. Update now?",
                PrimaryButtonText = "Update",
                CloseButtonText = "Later"
            };

            if (await dialog.ShowAsync() == ContentDialogResult.Primary)
            {
                // Open Play Store
                await Launcher.OpenAsync(
                    "market://details?id=com.companyname.myapp");
            }
        }
    }
}
```

## Play Store Link

```uri
market://details?id=com.companyname.myapp
https://play.google.com/store/apps/details?id=com.companyname.myapp
```

## Auto Updates

Google Play updates your app automatically by default (user-configurable). You can also use Play Core In-app Updates API for forced updates.

---

**Next:** [Module 12 — Projects](../12-projects/01-todo-app.md)
