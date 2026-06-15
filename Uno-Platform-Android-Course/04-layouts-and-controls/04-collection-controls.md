# Collection Controls

## ListView — Vertical List

```xml
<ListView ItemsSource="{Binding Products}"
          SelectionMode="Single"
          ItemClick="OnProductClick"
          IsItemClickEnabled="True">
    <ListView.ItemTemplate>
        <DataTemplate>
            <StackPanel Padding="12">
                <TextBlock Text="{Binding Name}" FontWeight="SemiBold" />
                <TextBlock Text="{Binding Price, StringFormat='${0}'}"
                           Foreground="Gray" />
            </StackPanel>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```

## GridView — Grid Layout

```xml
<GridView ItemsSource="{Binding Photos}"
          SelectionMode="None">
    <GridView.ItemTemplate>
        <DataTemplate>
            <Border Width="150" Height="150" CornerRadius="12">
                <Image Source="{Binding Thumbnail}" Stretch="UniformToFill" />
            </Border>
        </DataTemplate>
    </GridView.ItemTemplate>
</GridView>
```

## ItemsRepeater (Modern, Lightweight)

```xml
<ScrollViewer>
    <ItemsRepeater ItemsSource="{Binding Items}"
                   Layout="...">
        <ItemsRepeater.ItemTemplate>
            <DataTemplate>
                <Border Padding="8" Background="{ThemeResource CardBackgroundFillColorDefaultBrush}">
                    <TextBlock Text="{Binding Title}" />
                </Border>
            </DataTemplate>
        </ItemsRepeater.ItemTemplate>
    </ItemsRepeater>
</ScrollViewer>
```

## Grouped Collections

```csharp
// Group items
var grouped = items.GroupBy(x => x.Category)
    .Select(g => new GroupInfo(g.Key, g.ToList()))
    .ToList();

// Use CollectionViewSource
var cvs = new CollectionViewSource
{
    Source = grouped,
    IsSourceGrouped = true
};
```

```xml
<ListView ItemsSource="{Binding cvs.View}">
    <ListView.GroupStyle>
        <GroupStyle>
            <GroupStyle.HeaderTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding Key}" FontWeight="Bold" />
                </DataTemplate>
            </GroupStyle.HeaderTemplate>
        </GroupStyle>
    </ListView.GroupStyle>
</ListView>
```

## Pull-to-Refresh

```xml
<RefreshContainer RefreshRequested="OnRefreshRequested">
    <ScrollViewer>
        <ListView ItemsSource="{Binding Items}" />
    </ScrollViewer>
</RefreshContainer>
```

---

**Next:** [Custom Controls](05-custom-controls.md)
