# Animations

## Visual States

```xml
<Grid>
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup x:Name="CommonStates">
            <VisualState x:Name="Normal">
                <VisualState.Setters>
                    <Setter Target="MyElement.Opacity" Value="1" />
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Pressed">
                <VisualState.Setters>
                    <Setter Target="MyElement.Opacity" Value="0.5" />
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>

    <Border x:Name="MyElement" Background="Blue" Width="100" Height="100" />
</Grid>
```

## Storyboard Animations

```xml
<Page.Resources>
    <Storyboard x:Name="FadeIn">
        <DoubleAnimation Storyboard.TargetName="MyBox"
                         Storyboard.TargetProperty="Opacity"
                         From="0" To="1" Duration="0:0:0.3" />
    </Storyboard>
</Page.Resources>
```

```csharp
FadeIn.Begin();
```

## Code-Behind Animations

```csharp
// Animate opacity
var animation = new DoubleAnimation
{
    From = 0,
    To = 1,
    Duration = new Duration(TimeSpan.FromMilliseconds(300))
};
Storyboard.SetTarget(animation, MyElement);
Storyboard.SetTargetProperty(animation, "Opacity");
var sb = new Storyboard();
sb.Children.Add(animation);
sb.Begin();
```

## Transitions (Simple Page Transitions)

```xml
<!-- Page transition -->
<Page.Transitions>
    <TransitionCollection>
        <NavigationThemeTransition />
    </TransitionCollection>
</Page.Transitions>

<!-- Element entrance -->
<Border>
    <Border.Transitions>
        <TransitionCollection>
            <EntranceThemeTransition FromHorizontalOffset="50" />
        </TransitionCollection>
    </Border.Transitions>
</Border>
```

## Implicit Animations (Theme Transitions)

```xml
<Button Content="Save">
    <Button.Resources>
        <ThemeTransition>
            <PopupThemeTransition />
        </ThemeTransition>
    </Button.Resources>
</Button>
```

---

**Next:** [Module 4 — Layouts & Controls](../04-layouts-and-controls/01-layout-panels.md)
