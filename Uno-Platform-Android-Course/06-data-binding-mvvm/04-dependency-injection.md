# Dependency Injection

## Why DI?

- **Decouples** classes from their dependencies
- **Easier testing** — swap real services with mocks
- **Singleton/Transient** management
- **Standard** in .NET / Uno

## Setup in App.xaml.cs

```csharp
public App()
{
    this.InitializeComponent();
}

protected override void OnLaunched(LaunchActivatedEventArgs args)
{
    var services = new ServiceCollection();
    ConfigureServices(services);
    var provider = services.BuildServiceProvider();

    MainWindow = new Window();
    var rootFrame = new Frame();
    MainWindow.Content = rootFrame;
    rootFrame.Navigate(typeof(LoginPage));
    MainWindow.Activate();
}

void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<IProductService, ProductService>();
    services.AddSingleton<ISettingsService, SettingsService>();
    services.AddTransient<LoginViewModel>();
    services.AddTransient<HomeViewModel>();
}
```

## Constructor Injection

```csharp
public class LoginPage : Page
{
    public LoginViewModel ViewModel { get; }

    public LoginPage()
    {
        this.InitializeComponent();
        // Get service from app's service provider
        ViewModel = (App.Current as App)?.ServiceProvider
            .GetRequiredService<LoginViewModel>()!;
        DataContext = ViewModel;
    }
}
```

## Better: App as Service Locator

```csharp
public partial class App : Application
{
    public IServiceProvider Services { get; private set; } = null!;

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        var services = new ServiceCollection();
        // register...
        Services = services.BuildServiceProvider();
        // ...
    }
}
```

Then anywhere:

```csharp
var vm = (App.Current as App)!.Services.GetRequiredService<LoginViewModel>();
```

## Registration Lifetimes

| Lifetime | Behavior |
|----------|----------|
| `AddSingleton` | One instance for app lifetime |
| `AddTransient` | New instance every time |
| `AddScoped` | One per scope (rare in mobile) |

## Dependency Injection with Pages

For constructor injection on Pages, you'll need to resolve pages manually:

```csharp
services.AddTransient<LoginPage>();
services.AddTransient<HomePage>();

// Navigation
var page = Services.GetRequiredService<LoginPage>();
rootFrame.Navigate(typeof(LoginPage)); // won't work with ctor injection
// Instead, register factory or use navigation service
```

---

**Next:** [MVUX](05-mvux.md)
