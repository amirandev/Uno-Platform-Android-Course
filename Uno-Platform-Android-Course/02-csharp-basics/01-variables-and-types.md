# C# Variables & Types for Mobile Dev

## Basic Types

```csharp
int count = 42;               // Integer
double price = 19.99;         // Double-precision float
float ratio = 1.5f;           // Single-precision float
decimal total = 100.50m;      // High-precision (money)
bool isEnabled = true;        // Boolean
char letter = 'A';            // Single character
string name = "Alice";        // Text
```

## Type Inference (var)

```csharp
var age = 30;                 // int
var label = "Welcome";        // string
var items = new List<string>(); // List<string>
```

## Nullable Types

```csharp
string? maybeNull = null;     // Nullable reference
int? optional = null;         // Nullable value type

if (maybeNull != null) {
    Console.WriteLine(maybeNull.Length);
}

// Safe navigation
int? len = maybeNull?.Length;
string result = maybeNull ?? "default";
```

## Common Mobile Types

```csharp
// These come from Uno/WinUI namespaces
Color accentColor = Colors.Blue;
Thickness padding = new(16);
GridLength star = new(1, GridUnitType.Star);
Point position = new(100, 200);
Size imageSize = new(300, 200);
```

## Type Conversion

```csharp
int number = int.Parse("42");           // string → int
string text = 99.ToString();            // int → string
double d = (double)count;               // explicit cast
```

---

**Next:** [Control Flow](02-control-flow.md)
