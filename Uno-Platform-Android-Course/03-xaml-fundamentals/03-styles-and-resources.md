# Styles & Resources

## Theme Resources

Built-in brushes and colors:

```xml
<Border Background="{ThemeResource SystemAccentColor}" />
<TextBlock Foreground="{ThemeResource SystemControlForegroundBaseHighBrush}" />
```

Common theme resources:

| Resource | Purpose |
|----------|---------|
| `SystemAccentColor` | App accent color |
| `ApplicationPageBackgroundThemeBrush` | Page background |
| `CardBackgroundFillColorDefaultBrush` | Card surfaces |
| `SystemControlForegroundBaseHighBrush` | Primary text |
| `SystemControlForegroundBaseMediumBrush` | Secondary text |

## Defining Resources

```xml
<Page.Resources>
    <SolidColorBrush x:Key="PrimaryBrush" Color="#512BD4" />
    <x:Double x:Key="CornerRadius">12</x:Double>
</Page.Resources>

<!-- Usage -->
<Button Background="{StaticResource PrimaryBrush}"
        CornerRadius="{StaticResource CornerRadius}" />
```

## Styles

```xml
<Page.Resources>
    <Style x:Key="PrimaryButton" TargetType="Button">
        <Setter Property="Background" Value="{ThemeResource SystemAccentColor}" />
        <Setter Property="Foreground" Value="White" />
        <Setter Property="CornerRadius" Value="8" />
        <Setter Property="Height" Value="44" />
        <Setter Property="FontWeight" Value="SemiBold" />
    </Style>
</Page.Resources>

<Button Style="{StaticResource PrimaryButton}" Content="Login" />
```

## Implicit Styles (applies to all of a type)

```xml
<Style TargetType="Button">
    <Setter Property="CornerRadius" Value="8" />
</Style>
```

## App-Level Resources

Put in `App.xaml` for global access:

```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls" />
        </ResourceDictionary.MergedDictionaries>
        <SolidColorBrush x:Key="AppAccent" Color="#512BD4" />
    </ResourceDictionary>
</Application.Resources>
```

---

**Next:** [Templates](04-templates.md)
