# Methods & Classes

## Methods

```csharp
// Basic method
int Add(int a, int b) => a + b;

// Async method
async Task<string> FetchDataAsync(string url)
{
    using var client = new HttpClient();
    return await client.GetStringAsync(url);
}

// Void event handler
void OnButtonClick(object sender, RoutedEventArgs e)
{
    // handle click
}
```

## Classes

```csharp
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name) => Name = name;

    public string Greet() => $"Hi, I'm {Name}";
}
```

## Records (Modern C#)

```csharp
// Immutable data object
public record Product(string Name, decimal Price);

// With inheritance
public record Book(string Title, string Author) : Product(Title, 29.99m);
```

## Partial Classes (Used in XAML)

```csharp
// MainPage.xaml.cs — code-behind
public sealed partial class MainPage : Page
{
    // This is the other half of MainPage.xaml
}
```

## Static Members

```csharp
public static class AppConfig
{
    public static string ApiUrl { get; set; } = "https://api.example.com";
    public static int TimeoutSeconds => 30;
}
```

---

**Next:** [Collections & LINQ](04-collections-and-linq.md)
