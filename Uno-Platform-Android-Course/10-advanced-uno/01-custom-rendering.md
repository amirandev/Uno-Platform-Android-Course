# Custom Rendering & Native Interop

## Platform-Specific Code

Use `#if` directives for platform-specific logic:

```csharp
public static class DeviceInfo
{
    public static string GetDeviceName()
    {
#if __ANDROID__
        return $"{Android.OS.Build.Manufacturer} {Android.OS.Build.Model}";
#elif __IOS__
        return UIKit.UIDevice.CurrentDevice.Name;
#else
        return "Unknown";
#endif
    }
}
```

## Accessing Android APIs

```csharp
#if __ANDROID__
using Android.Content;
using Android.Widget;

void ShowAndroidToast(string message)
{
    var context = Android.App.Application.Context;
    Toast.MakeText(context, message, ToastLength.Short).Show();
}
#endif
```

## Native View Hosting

Host a native Android view inside Uno:

```csharp
#if __ANDROID__
var nativeMap = new Android.Gms.Maps.MapView(context);
var host = new Microsoft.UI.Xaml.Controls.NativeViewHolder(nativeMap);
MyGrid.Children.Add(host);
#endif
```

## Custom Skia Drawing

```xml
<skia:SKXamlCanvas PaintSurface="OnPaintSurface" />
```

```csharp
void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
{
    var canvas = e.Surface.Canvas;
    canvas.Clear(SKColors.White);
    using var paint = new SKPaint
    {
        Color = SKColors.Blue,
        IsAntialias = true
    };
    canvas.DrawCircle(100, 100, 50, paint);
}
```

## Community Libraries

- **Uno.Toolkit** — Additional controls (TabBar, NavigationBar, etc.)
- **Uno.Cupertino** — iOS-style controls
- **Uno.Material** — Material Design 3 controls
- **SkiaSharp** — 2D graphics rendering
- **Lottie** — After Effects animations

---

**Next:** [Performance Optimization](02-performance-optimization.md)
