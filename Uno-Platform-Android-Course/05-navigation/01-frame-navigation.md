# Frame Navigation

## The Navigation Pattern

Uno apps use a `Frame` to host pages and navigate between them:

```
App.xaml.cs  →  Frame → LoginPage
                             ↓ (login success)
                          HomePage
```

## Setup in App.xaml.cs

```csharp
protected override void OnLaunched(LaunchActivatedEventArgs args)
{
    MainWindow = new Window();
    var rootFrame = new Frame();
    MainWindow.Content = rootFrame;
    rootFrame.Navigate(typeof(LoginPage));
    MainWindow.Activate();
}
```

## Navigate to a Page

```csharp
// In any Page's code-behind
Frame.Navigate(typeof(HomePage));
```

## Go Back

```csharp
if (Frame.CanGoBack)
    Frame.GoBack();
```

## Passing Parameters

```csharp
// Navigate with parameter
Frame.Navigate(typeof(DetailPage), product.Id);

// Receive in target page
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    var productId = (int)e.Parameter;
    LoadProduct(productId);
}
```

## Forward and Back Stack

```csharp
// Clear back stack (after login — user shouldn't go back)
Frame.BackStack.Clear();
Frame.Navigate(typeof(HomePage));

// Remove last back entry
Frame.BackStack.RemoveAt(Frame.BackStack.Count - 1);
```

## Navigation Events

```csharp
// Page lifecycle
protected override void OnNavigatedTo(NavigationEventArgs e) { }
protected override void OnNavigatingFrom(NavigatingCancelEventArgs e) { }
protected override void OnNavigatedFrom(NavigationEventArgs e) { }
```

## Simple Navigation Service

```csharp
public static class Nav
{
    private static Frame? _frame;

    public static void Initialize(Frame frame) => _frame = frame;

    public static void GoTo(Type page, object? param = null)
        => _frame?.Navigate(page, param);

    public static void GoBack()
    {
        if (_frame?.CanGoBack == true)
            _frame.GoBack();
    }
}
```

---

**Next:** [Passing Data](02-passing-data.md)
