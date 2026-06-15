# Data Templates & Control Templates

## DataTemplate — How Items Are Rendered

```xml
<ListView ItemsSource="{Binding Products}">
    <ListView.ItemTemplate>
        <DataTemplate>
            <Border Padding="12" Margin="4" CornerRadius="8"
                    Background="{ThemeResource CardBackgroundFillColorDefaultBrush}">
                <StackPanel Spacing="4">
                    <TextBlock Text="{Binding Name}" FontWeight="SemiBold" />
                    <TextBlock Text="{Binding Price, StringFormat='${0:F2}'}"
                               Foreground="{ThemeResource SystemAccentColor}" />
                </StackPanel>
            </Border>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```

## ControlTemplate — Customizing Control Appearance

```xml
<Button Content="Save">
    <Button.Template>
        <ControlTemplate TargetType="Button">
            <Border x:Name="Root"
                    Background="{TemplateBinding Background}"
                    CornerRadius="12"
                    Padding="16,8">
                <ContentPresenter Content="{TemplateBinding Content}" />
            </Border>
        </ControlTemplate>
    </Button.Template>
</Button>
```

## ItemTemplateSelector — Different Templates Per Item

```csharp
public class MessageTemplateSelector : DataTemplateSelector
{
    public DataTemplate IncomingTemplate { get; set; }
    public DataTemplate OutgoingTemplate { get; set; }

    protected override DataTemplate SelectTemplateCore(object item)
    {
        var msg = (Message)item;
        return msg.IsMine ? OutgoingTemplate : IncomingTemplate;
    }
}
```

```xml
<ListView ItemsSource="{Binding Messages}">
    <ListView.ItemTemplateSelector>
        <local:MessageTemplateSelector>
            <local:MessageTemplateSelector.IncomingTemplate>
                <DataTemplate>...</DataTemplate>
            </local:MessageTemplateSelector.IncomingTemplate>
            <local:MessageTemplateSelector.OutgoingTemplate>
                <DataTemplate>...</DataTemplate>
            </local:MessageTemplateSelector.OutgoingTemplate>
        </local:MessageTemplateSelector>
    </ListView.ItemTemplateSelector>
</ListView>
```

---

**Next:** [Animations](05-animations.md)
