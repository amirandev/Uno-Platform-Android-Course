# MVUX (Model-View-Update eXtended)

MVUX is Uno's modern pattern — less boilerplate than MVVM.

## Key Concepts

- **Model** — pure data (records)
- **View** — XAML page
- **Update** — automatic UI updates via `IState<T>`
- **Feeds** — reactive data streams (like RxJS Observables)

## Simple MVUX Example

### Model

```csharp
public record Product(string Name, decimal Price);
```

### Feed (ViewModel replacement)

```csharp
public class ProductsFeed
{
    public async ValueTask<IImmutableList<Product>> GetProductsAsync()
    {
        var products = await _service.GetAllAsync();
        return products.ToImmutableArray();
    }
}
```

### View

```xml
<Page x:Class="MyApp.Pages.ProductsPage"
      xmlns:mvux="using:Uno.Extensions.Mvux">

    <ListView ItemsSource="{Binding Products}">
        <ListView.ItemTemplate>
            <DataTemplate>
                <TextBlock Text="{Binding Name}" />
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</Page>
```

## State vs Feed

```csharp
// State — mutable, local
IState<int> Count => State.Value(this, () => 0);

// Feed — async, external source
IListFeed<Product> Products => ListFeed.Async(this, GetProductsAsync);

ValueTask<IImmutableList<Product>> GetProductsAsync(CancellationToken ct)
    => _service.GetAllAsync().AsTask().AsValueTask();
```

## Commands in MVUX

```csharp
public async ValueTask AddItem(string name)
{
    await _service.AddAsync(name);
}
```

## Why MVUX?

- Less code than MVVM (no `INotifyPropertyChanged` boilerplate)
- Reactive by default
- Built-in loading/error states
- Cancellation token support

---

**Next:** [Module 7 — Working with Data](../07-working-with-data/01-settings-and-preferences.md)
