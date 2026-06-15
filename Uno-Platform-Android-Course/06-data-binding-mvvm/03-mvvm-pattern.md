# MVVM Pattern

## The Three Layers

```
View (XAML) ←→ ViewModel (C#) ←→ Model (C#)
    UI              Logic             Data
```

| Layer | Responsibility |
|-------|---------------|
| **View** | XAML layout, animations, visual states. Binds to ViewModel. |
| **ViewModel** | Commands, observable properties, navigation, business logic. |
| **Model** | Data objects, database, API clients, services. |

## ViewModel Base

```csharp
public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string name = "")
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private bool _isBusy;
    public bool IsBusy
    {
        get => _isBusy;
        set => SetProperty(ref _isBusy, value);
    }
}
```

## Full ViewModel Example

```csharp
public class ProductsViewModel : ViewModelBase
{
    private readonly IProductService _service;
    private string _searchText = "";

    public string SearchText
    {
        get => _searchText;
        set
        {
            SetProperty(ref _searchText, value);
            _ = SearchAsync(); // debounce in real app
        }
    }

    public ObservableCollection<Product> Products { get; } = new();

    public ICommand RefreshCommand { get; }
    public ICommand SelectCommand { get; }

    public ProductsViewModel(IProductService service)
    {
        _service = service;
        RefreshCommand = new AsyncRelayCommand(LoadAsync);
        SelectCommand = new RelayCommand<Product>(OnProductSelected);
    }

    async Task LoadAsync()
    {
        IsBusy = true;
        var items = await _service.GetProductsAsync();
        Products.Clear();
        foreach (var item in items) Products.Add(item);
        IsBusy = false;
    }

    void OnProductSelected(Product? product)
    {
        if (product is null) return;
        // Navigate to detail
    }
}
```

## View (XAML) Wiring

```xml
<Page x:Class="MyApp.Pages.ProductsPage"
      xmlns:vm="using:MyApp.ViewModels">

    <Page.Resources>
        <vm:ProductsViewModel x:Key="ViewModel" />
    </Page.Resources>

    <Grid DataContext="{StaticResource ViewModel}">
        <ListView ItemsSource="{Binding Products}">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding Name}" />
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>
    </Grid>
</Page>
```

## Why MVVM?

- **Testable** — ViewModel = plain C#, no UI dependency
- **Maintainable** — Separation of concerns
- **Reusable** — Same ViewModel for Android, iOS, Web
- **Designer-friendly** — Designers work on XAML, devs on ViewModel

---

**Next:** [Dependency Injection](04-dependency-injection.md)
