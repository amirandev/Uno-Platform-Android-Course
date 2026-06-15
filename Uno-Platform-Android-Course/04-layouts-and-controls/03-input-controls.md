# Input Controls

## DatePicker

```xml
<DatePicker Date="{x:Bind ViewModel.BirthDate, Mode=TwoWay}"
            MinYear="1900" MaxYear="2030" />
```

## TimePicker

```xml
<TimePicker Time="{x:Bind ViewModel.AlarmTime, Mode=TwoWay}" />
```

## ComboBox (Dropdown)

```xml
<ComboBox ItemsSource="{Binding Countries}"
          SelectedItem="{Binding SelectedCountry, Mode=TwoWay}"
          PlaceholderText="Select a country">
    <ComboBox.ItemTemplate>
        <DataTemplate>
            <TextBlock Text="{Binding Name}" />
        </DataTemplate>
    </ComboBox.ItemTemplate>
</ComboBox>
```

## AutoSuggestBox (Search with Suggestions)

```xml
<AutoSuggestBox PlaceholderText="Search products"
                TextChanged="OnSearchTextChanged"
                SuggestionChosen="OnSuggestionChosen"
                ItemsSource="{Binding Suggestions}" />
```

## Slider with Value Display

```xml
<StackPanel Orientation="Horizontal" Spacing="12">
    <TextBlock Text="{x:Bind Volume.ToString(), Mode=OneWay}" Width="30" />
    <Slider Width="200" Minimum="0" Maximum="100"
            Value="{x:Bind Volume, Mode=TwoWay}" />
</StackPanel>
```

## ToggleButton

```xml
<ToggleButton Content="Dark Mode"
              IsChecked="{x:Bind ViewModel.IsDarkMode, Mode=TwoWay}" />
```

## RadioButton

```xml
<RadioButton Content="Option A" GroupName="Options" />
<RadioButton Content="Option B" GroupName="Options" />
```

---

**Next:** [Collection Controls](04-collection-controls.md)
