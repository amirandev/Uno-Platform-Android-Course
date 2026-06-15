# Navigation Patterns

## Auth Guard — Login → Home Flow

```csharp
// App.xaml.cs
if (IsLoggedIn)
    rootFrame.Navigate(typeof(HomePage));
else
    rootFrame.Navigate(typeof(LoginPage));

// LoginPage — on success
Frame.BackStack.Clear(); // prevent back to login
Frame.Navigate(typeof(HomePage));
```

## Shell Navigation (Header + Footer)

Create a layout UserControl:

```xml
<!-- AppLayout.xaml -->
<Grid RowDefinitions="Auto,*,Auto">
    <local:AppHeader Grid.Row="0" />
    <ContentControl Grid.Row="1" Content="{x:Bind BodyContent}" />
    <local:AppFooter Grid.Row="2" />
</Grid>
```

Each page wraps content in the layout:

```xml
<Page>
    <local:AppLayout>
        <ListView ItemsSource="{Binding Items}" />
    </local:AppLayout>
</Page>
```

## Tab Navigation

Use bottom tabs via a `Pivot` or custom `RadioButton` approach:

```xml
<Pivot>
    <PivotItem Header="Home">
        <local:HomeContent />
    </PivotItem>
    <PivotItem Header="Search">
        <local:SearchContent />
    </PivotItem>
    <PivotItem Header="Profile">
        <local:ProfileContent />
    </PivotItem>
</Pivot>
```

## Deep Linking (Receiving External URLs)

```csharp
// AndroidManifest.xml
<intent-filter>
    <action android:name="android.intent.action.VIEW" />
    <category android:name="android.intent.category.DEFAULT" />
    <data android:scheme="myapp" />
</intent-filter>

// Handle in MainActivity
protected override void OnNewIntent(Intent intent)
{
    var data = intent?.Data?.ToString();
    // "myapp://product/42" → navigate to detail
}
```

---

**Next:** [Module 6 — Data Binding & MVVM](../06-data-binding-mvvm/01-data-binding.md)
