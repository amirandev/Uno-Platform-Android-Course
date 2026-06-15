# Custom Controls

## UserControl — Composing Existing Controls

### MyCard.xaml

```xml
<UserControl x:Class="MyApp.Controls.MyCard">
    <Border CornerRadius="12" Padding="16"
            Background="{ThemeResource CardBackgroundFillColorDefaultBrush}">
        <StackPanel Spacing="8">
            <TextBlock x:Name="TitleText" FontSize="18" FontWeight="SemiBold" />
            <TextBlock x:Name="DescriptionText" Foreground="Gray" />
            <ContentPresenter x:Name="ActionContent" />
        </StackPanel>
    </Border>
</UserControl>
```

### MyCard.xaml.cs

```csharp
public sealed partial class MyCard : UserControl
{
    public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(nameof(Title), typeof(string),
            typeof(MyCard), new PropertyMetadata("", (d, e) =>
                ((MyCard)d).TitleText.Text = (string)e.NewValue));

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    // ... same for Description, etc.
}
```

### Usage

```xml
<controls:MyCard Title="Welcome" Description="Hello world">
    <Button Content="Action" />
</controls:MyCard>
```

## Templated Control (Full Custom)

Best for when you need full WinUI styling/theming support. Use `TemplatedControl` + `DefaultStyleKey`.

```csharp
public class RatingControl : Control
{
    protected override void OnApplyTemplate()
    {
        // Get template parts
        var star1 = GetTemplateChild("Star1") as Button;
    }
}
```

`Generic.xaml` (in `Themes/` folder):

```xml
<Style TargetType="local:RatingControl">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="local:RatingControl">
                <StackPanel Orientation="Horizontal">
                    <Button x:Name="Star1" Content="★" />
                    <Button x:Name="Star2" Content="★" />
                </StackPanel>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

---

**Next:** [Module 5 — Navigation](../05-navigation/01-frame-navigation.md)
