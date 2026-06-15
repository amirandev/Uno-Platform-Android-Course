# Layout Panels

## Grid — The Workhorse

```xml
<Grid RowDefinitions="Auto,*,Auto" ColumnDefinitions="*,*">
    <TextBlock Grid.Row="0" Grid.ColumnSpan="2" Text="Header" />
    <ListView Grid.Row="1" Grid.Column="0" />
    <StackPanel Grid.Row="1" Grid.Column="1" />
    <Border Grid.Row="2" Grid.ColumnSpan="2" Height="60" />
</Grid>
```

| GridUnitType | Example | Behavior |
|---|---|---|
| `Auto` | `Auto` | Sizes to content |
| `*` | `*` | Takes remaining space (proportional) |
| `Pixel` | `100` | Fixed size |

## StackPanel — Vertical or Horizontal Stack

```xml
<StackPanel Orientation="Vertical" Spacing="12" Padding="16">
    <TextBlock Text="Item 1" />
    <TextBlock Text="Item 2" />
    <Button Content="Submit" />
</StackPanel>
```

## FlexPanel — Modern Flexbox-like Layout

```xml
<FlexPanel Wrap="Wrap" JustifyContent="Center" Gap="8">
    <Border Width="100" Height="100" Background="Red" />
    <Border Width="100" Height="100" Background="Blue" />
    <Border Width="100" Height="100" Background="Green" />
</FlexPanel>
```

## ScrollViewer

```xml
<ScrollViewer>
    <StackPanel>
        <!-- Content taller than screen -->
    </StackPanel>
</ScrollViewer>
```

## RelativePanel

```xml
<RelativePanel>
    <TextBox x:Name="SearchBox" RelativePanel.AlignLeftWithPanel="True" />
    <Button Content="Go" RelativePanel.RightOf="SearchBox" />
</RelativePanel>
```

## Canvas (Absolute Positioning)

```xml
<Canvas>
    <Rectangle Canvas.Left="50" Canvas.Top="100" Width="200" Height="100" />
</Canvas>
```

---

**Next:** [Common Controls](02-common-controls.md)
