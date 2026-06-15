# UI Testing

## Uno.UITest Framework

Write cross-platform UI tests:

```csharp
[TestClass]
public class LoginTests
{
    [TestMethod]
    public void Login_Success_NavigatesToHome()
    {
        var app = AppManager.StartPlatform();

        // Find elements
        var usernameBox = app.Marked("UsernameBox");
        var passwordBox = app.Marked("PasswordBox");
        var loginButton = app.Marked("LoginButton");

        // Interact
        usernameBox.EnterText("alice");
        passwordBox.EnterText("password");
        loginButton.Tap();

        // Assert
        var homeHeader = app.Marked("HomeHeader");
        Assert.IsTrue(homeHeader.IsDisplayed);
    }
}
```

## Test Setup

Add to `app.manifest`:
```xml
[Activity(UiAutomation = UiAutomationMode.Enabled)]
```

## XAML Automation IDs

```xml
<TextBox x:Name="UsernameBox"
         AutomationProperties.AutomationId="UsernameBox" />
<Button x:Name="LoginButton"
        AutomationProperties.AutomationId="LoginButton"
        Content="Login" />
```

## Running Tests

```powershell
dotnet test MyApp.UITests/MyApp.UITests.csproj
```

---

**Next:** [Publishing](../11-publishing/01-app-signing.md)
