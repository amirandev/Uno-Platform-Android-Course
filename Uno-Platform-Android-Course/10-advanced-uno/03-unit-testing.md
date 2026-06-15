# Unit Testing

## Testing ViewModels

```csharp
[TestClass]
public class LoginViewModelTests
{
    [TestMethod]
    public async Task Login_WithValidCredentials_NavigatesToHome()
    {
        // Arrange
        var mockApi = new Mock<IAuthService>();
        mockApi.Setup(x => x.LoginAsync("alice", "pass"))
               .ReturnsAsync(true);

        var vm = new LoginViewModel(mockApi.Object);

        // Act
        vm.Username = "alice";
        vm.Password = "pass";
        await vm.LoginCommand.ExecuteAsync(null);

        // Assert
        Assert.IsTrue(vm.IsLoggedIn);
    }

    [TestMethod]
    public async Task Login_WithInvalidCredentials_ShowsError()
    {
        var mockApi = new Mock<IAuthService>();
        mockApi.Setup(x => x.LoginAsync(It.IsAny<string>(), It.IsAny<string>()))
               .ReturnsAsync(false);

        var vm = new LoginViewModel(mockApi.Object);
        vm.Username = "bad";
        vm.Password = "wrong";

        await vm.LoginCommand.ExecuteAsync(null);

        Assert.IsFalse(string.IsNullOrEmpty(vm.ErrorMessage));
    }
}
```

## Testing Services

```csharp
[TestClass]
public class ProductServiceTests
{
    [TestMethod]
    public async Task GetProducts_ReturnsList()
    {
        // Arrange
        var mockHttp = new Mock<HttpClient>();
        // Setup mock response...
        var service = new ProductService(mockHttp.Object);

        // Act
        var products = await service.GetAllAsync();

        // Assert
        Assert.IsNotNull(products);
        Assert.IsTrue(products.Count > 0);
    }
}
```

## Test Project Setup

Add a unit test project to your solution:

```powershell
dotnet new unoapp-uitest -n MyApp.Tests
```

Or use a standard `mstest`/`xunit` project with `using Uno.Extensions.Reactive.Testing;`.

---

**Next:** [UI Testing](04-ui-testing.md)
