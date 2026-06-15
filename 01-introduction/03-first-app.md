# Your First Uno Platform App

## Create the Project

```powershell
dotnet new unoapp -n HelloUno -o HelloUno -platforms android
```

## Project Structure

```
HelloUno/
└── HelloUno/
    ├── App.xaml / App.xaml.cs     # Application entry point
    ├── MainPage.xaml / .cs        # Main page
    ├── Platforms/
    │   └── Android/              # Android-specific code
    ├── Assets/                   # Images, fonts, icons
    ├── app.manifest              # Android manifest
    └── SampleApp.csproj          # Project file (Uno.Sdk)
```

## Hello World Walkthrough

### App.xaml.cs

```csharp
protected override void OnLaunched(LaunchActivatedEventArgs args)
{
    MainWindow = new Window();
    var rootFrame = new Frame();
    MainWindow.Content = rootFrame;
    rootFrame.Navigate(typeof(MainPage));
    MainWindow.Activate();
}
```

### MainPage.xaml

```xml
<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation">
    <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
        <TextBlock Text="Hello Uno!" FontSize="32" />
        <TextBlock Text="Running on Android" Foreground="Gray" />
    </StackPanel>
</Page>
```

### MainPage.xaml.cs

```csharp
namespace HelloUno;
public sealed partial class MainPage : Page
{
    public MainPage() => this.InitializeComponent();
}
```

## Run It

```powershell
dotnet build -t:Run
```

---

**Next:** [Project Structure](04-project-structure.md)
