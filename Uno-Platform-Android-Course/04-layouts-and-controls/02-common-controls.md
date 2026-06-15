# Common Controls

## TextBlock — Display Text

```xml
<TextBlock Text="Hello"
           FontSize="24"
           FontWeight="Bold"
           Foreground="{ThemeResource SystemAccentColor}"
           TextWrapping="Wrap" />
```

## TextBox — Input Text

```xml
<TextBox PlaceholderText="Enter your name"
         Text="{x:Bind ViewModel.Name, Mode=TwoWay}"
         CornerRadius="8"
         MaxLength="50" />
```

## PasswordBox

```xml
<PasswordBox PlaceholderText="Password"
             Password="{x:Bind ViewModel.Password, Mode=TwoWay}"
             CornerRadius="8" />
```

## Button

```xml
<Button Content="Login"
        Click="OnLoginClick"
        CornerRadius="8"
        Height="44"
        Background="{ThemeResource SystemAccentColor}"
        Foreground="White" />
```

## CheckBox

```xml
<CheckBox Content="Remember me"
          IsChecked="{x:Bind ViewModel.RememberMe, Mode=TwoWay}" />
```

## ToggleSwitch

```xml
<ToggleSwitch OnContent="On" OffContent="Off"
              IsOn="{x:Bind ViewModel.IsEnabled, Mode=TwoWay}" />
```

## Slider

```xml
<Slider Minimum="0" Maximum="100"
        Value="{x:Bind ViewModel.Volume, Mode=TwoWay}"
        StepFrequency="5" />
```

## ProgressBar / ProgressRing

```xml
<ProgressBar Value="{x:Bind ViewModel.Progress}" />
<ProgressRing IsActive="{x:Bind ViewModel.IsLoading}" />
```

## InfoBar (Modern Alert)

```xml
<InfoBar Title="Saved!" Severity="Success"
         IsOpen="True" />
```

---

**Next:** [Input Controls](03-input-controls.md)
