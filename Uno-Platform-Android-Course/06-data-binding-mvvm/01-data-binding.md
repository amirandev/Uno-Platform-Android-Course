# Data Binding

## What is Data Binding?

Data binding connects a UI property to a C# property — when the data changes, the UI updates automatically (and vice versa).

## Basic Binding

```xml
<TextBlock Text="{Binding UserName}" />
```

## Binding Modes

| Mode | Direction | Use Case |
|------|-----------|----------|
| `OneWay` | Source → Target | Display data (read-only) |
| `TwoWay` | Source ↔ Target | Input fields |
| `OneTime` | Source → Target (once) | Static data, performance |
| `OneWayToSource` | Target → Source | Rarely used |

```xml
<TextBox Text="{Binding Name, Mode=TwoWay}" />
<TextBlock Text="{Binding Total, Mode=OneWay}" />
```

## x:Bind (Compiled Bindings)

Faster, type-safe, checked at compile time:

```xml
<Page x:DataType="local:MyViewModel">
    <TextBlock Text="{x:Bind ViewModel.Name, Mode=OneWay}" />
</Page>
```

```csharp
// Code-behind
public MyViewModel ViewModel { get; } = new();
```

## Binding to Elements

```xml
<Slider x:Name="SizeSlider" Minimum="10" Maximum="100" />
<Rectangle Width="{Binding ElementName=SizeSlider, Path=Value}" Height="50" />
```

## String Format

```xml
<TextBlock Text="{Binding Price, StringFormat='${0:F2}'}" />
<TextBlock Text="{Binding Date, StringFormat='{0:MMM dd, yyyy}'}" />
```

## Value Converters

```csharp
public class BoolToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string lang)
        => (bool)value ? Visibility.Visible : Visibility.Collapsed;

    public object ConvertBack(object value, Type targetType, object parameter, string lang)
        => (Visibility)value == Visibility.Visible;
}
```

```xml
<Application.Resources>
    <local:BoolToVisibilityConverter x:Key="BoolToVis" />
</Application.Resources>

<TextBlock Visibility="{Binding IsOnline, Converter={StaticResource BoolToVis}}" />
```

## Fallback & TargetNullValue

```xml
<TextBlock Text="{Binding Name, FallbackValue='N/A', TargetNullValue='Unknown'}" />
```

---

**Next:** [Commands](02-commands.md)
