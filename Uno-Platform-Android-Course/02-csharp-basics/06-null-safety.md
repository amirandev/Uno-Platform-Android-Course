# Null Safety

## Nullable vs Non-Nullable

```csharp
string name = "Alice";        // NEVER null (compiler ensures)
string? maybe = null;         // COULD be null
```

## The ?. Operator (Null-Conditional)

```csharp
int? length = maybe?.Length;  // null if maybe is null
string? city = user?.Address?.City;  // Safe chain
```

## The ?? Operator (Null-Coalescing)

```csharp
string display = name ?? "Guest";        // Use "Guest" if null
int count = items?.Length ?? 0;          // 0 if null
```

## The ! Operator (Null-Forgiving)

```csharp
// Use when you KNOW it's not null (compiler can't prove it)
string name = maybe!;
```

## Null Checks in Mobile

```csharp
// Safe navigation with UI elements
var text = MyTextBox?.Text ?? string.Empty;

// Guard clauses
void Process(User? user)
{
    if (user is null) return;
    // safe to use user here
}

// Pattern matching null check
if (result is not null)
{
    // use result
}
```

## Common Pitfalls

```csharp
// BAD — manual null check (prefer ?. and ??)
if (user != null) {
    var name = user.Name;
    if (name != null) {
        Console.WriteLine(name.Length);
    }
}

// GOOD — same logic, clean
Console.WriteLine(user?.Name?.Length ?? 0);
```

---

**Next:** [Module 3 — XAML Fundamentals](../03-xaml-fundamentals/01-xaml-syntax.md)
