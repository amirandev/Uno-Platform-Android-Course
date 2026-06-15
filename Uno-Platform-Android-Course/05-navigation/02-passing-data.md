# Passing Data Between Pages

## 1. Navigation Parameters (Simple)

```csharp
// Send
Frame.Navigate(typeof(DetailPage), new Product { Id = 1, Name = "Phone" });

// Receive
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    var product = e.Parameter as Product;
    if (product != null) { /* use it */ }
}
```

## 2. Static Service (Medium)

```csharp
public static class DataService
{
    public static Product? SelectedProduct { get; set; }
}

// Page A
DataService.SelectedProduct = product;
Frame.Navigate(typeof(DetailPage));

// Page B
var product = DataService.SelectedProduct;
```

## 3. Dependency Injection (Clean)

Register services in `App.xaml.cs`:

```csharp
var services = new ServiceCollection();
services.AddSingleton<IProductService, ProductService>();
services.AddTransient<DetailPageViewModel>();
```

Inject via constructor:

```csharp
public sealed partial class DetailPage : Page
{
    public DetailPageViewModel ViewModel { get; }

    public DetailPage(DetailPageViewModel vm)
    {
        this.InitializeComponent();
        ViewModel = vm;
    }
}
```

## 4. Messaging / Events (Decoupled)

```csharp
// Publish
WeakReferenceMessenger.Default.Send(new ProductSelectedMessage(product));

// Subscribe
WeakReferenceMessenger.Default.Register<ProductSelectedMessage>(this, (r, m) =>
{
    var product = m.Value;
});
```

## 5. Shared ViewModel

```csharp
// Register as singleton
services.AddSingleton<SharedState>();

// Both pages inject the same instance
public class PageA(SharedState state) { }
public class PageB(SharedState state) { }
```

---

**Next:** [Navigation Patterns](03-navigation-patterns.md)
