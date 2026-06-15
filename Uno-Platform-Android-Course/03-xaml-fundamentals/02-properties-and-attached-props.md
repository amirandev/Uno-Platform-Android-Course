# Properties & Attached Properties

## Dependency Properties

Uno/WinUI uses **Dependency Properties** — special properties that support data binding, styling, and animations.

```csharp
// Register a dependency property
public static readonly DependencyProperty IsFavoriteProperty =
    DependencyProperty.Register(nameof(IsFavorite), typeof(bool),
        typeof(MyControl), new PropertyMetadata(false));

public bool IsFavorite
{
    get => (bool)GetValue(IsFavoriteProperty);
    set => SetValue(IsFavoriteProperty, value);
}
```

## Attached Properties

Attached properties let you set a property on a child element that affects its parent layout.

```xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition Height="*" />
    </Grid.RowDefinitions>
    <TextBlock Grid.Row="0" Text="Header" />
    <ListView Grid.Row="1" />
</Grid>
```

## Custom Attached Property

```csharp
public static class GridExtensions
{
    public static readonly DependencyProperty IsDraggableProperty =
        DependencyProperty.RegisterAttached("IsDraggable", typeof(bool),
            typeof(GridExtensions), new PropertyMetadata(false));

    public static bool GetIsDraggable(DependencyObject obj)
        => (bool)obj.GetValue(IsDraggableProperty);

    public static void SetIsDraggable(DependencyObject obj, bool value)
        => obj.SetValue(IsDraggableProperty, value);
}
```

## Common Attached Properties

| Property | Used On | Purpose |
|----------|---------|---------|
| `Grid.Row`, `Grid.Column` | Any element | Grid positioning |
| `Grid.RowSpan`, `Grid.ColumnSpan` | Any element | Span across cells |
| `Canvas.Left`, `Canvas.Top` | Any element | Absolute positioning |
| `ScrollViewer.HorizontalScrollMode` | Panels | Scroll behavior |

---

**Next:** [Styles & Resources](03-styles-and-resources.md)
