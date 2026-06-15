# XAML Syntax

## What is XAML?

XAML (eXtensible Application Markup Language) is a declarative XML-based language for defining UI layouts and controls in Uno/WinUI.

## Basic Structure

```xml
<Page x:Class="MyApp.MainPage"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <StackPanel Padding="16">
        <TextBlock Text="Hello World" FontSize="24" />
        <Button Content="Click Me" Click="OnClick" />
    </StackPanel>
</Page>
```

## Namespaces

```xml
<!-- Default WinUI controls -->
xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
<!-- XAML language features -->
xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
<!-- Your app's code -->
xmlns:local="using:MyApp"
<!-- Controls from other namespaces -->
xmlns:controls="using:MyApp.Controls"
```

## Elements as Objects

Every XAML element = a C# class instance:

```xml
<Button Content="Save" />   <!-- Same as: new Button { Content = "Save" } -->
```

## Attributes as Properties

```xml
<TextBlock Text="Hello" FontSize="20" Foreground="Blue" />
```

## Property Element Syntax

For complex properties:

```xml
<Button>
    <Button.Content>
        <StackPanel Orientation="Horizontal">
            <SymbolIcon Symbol="Save" />
            <TextBlock Text="Save" />
        </StackPanel>
    </Button.Content>
</Button>
```

## Attached Properties

```xml
<Button Grid.Row="1" Grid.Column="2" Canvas.Left="50" />
```

## Markup Extensions (curly braces)

```xml
<TextBlock Text="{Binding Name}" />
<Button Command="{Binding SaveCommand}" />
<Rectangle Fill="{ThemeResource SystemAccentColor}" />
<TextBlock Text="{x:Bind ViewModel.Title, Mode=OneWay}" />
```

## x:Class and Code-Behind

Every XAML file pairs with a code-behind file (`.xaml.cs`) that defines its `x:Class`.

---

**Next:** [Properties & Attached Properties](02-properties-and-attached-props.md)
