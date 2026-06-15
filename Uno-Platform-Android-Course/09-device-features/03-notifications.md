# Notifications

## Local Notifications

Uno doesn't have a built-in local notification API — use platform-specific code or a community library.

### Simple Approach: ContentDialog

```csharp
async Task ShowNotificationAsync(string title, string message)
{
    var dialog = new ContentDialog
    {
        Title = title,
        Content = message,
        CloseButtonText = "OK",
        XamlRoot = this.XamlRoot // from Page
    };
    await dialog.ShowAsync();
}
```

## Toast-Style Notification

```csharp
// Custom toast-like overlay
public async Task ShowToastAsync(string message)
{
    var notification = new Border
    {
        Background = new SolidColorBrush(Colors.Black) { Opacity = 0.8 },
        CornerRadius = new CornerRadius(8),
        Padding = new Thickness(16, 10),
        HorizontalAlignment = HorizontalAlignment.Center,
        VerticalAlignment = VerticalAlignment.Top,
        Margin = new Thickness(0, 40, 0, 0),
        Child = new TextBlock
        {
            Text = message,
            Foreground = new SolidColorBrush(Colors.White)
        }
    };

    // Add to page root
    var root = (Grid)VisualTreeHelper.GetChild(Window.Current.Content, 0);
    root.Children.Add(notification);

    await Task.Delay(3000);
    root.Children.Remove(notification);
}
```

## Push Notifications (FCM)

For Google Play push notifications:

1. Set up Firebase project
2. Add `google-services.json` to your Android project
3. Use `Plugin.Firebase.CloudMessaging` (community plugin)
4. Handle notification received & opened events

---

**Next:** [Sensors](04-sensors.md)
