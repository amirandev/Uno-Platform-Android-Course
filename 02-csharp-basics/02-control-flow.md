# C# Control Flow

## Conditionals

```csharp
if (score >= 90) {
    grade = "A";
} else if (score >= 80) {
    grade = "B";
} else {
    grade = "F";
}

// Ternary
var status = isLoggedIn ? "Welcome" : "Login";
```

## Switch (Modern)

```csharp
var description = status switch
{
    "active" => "User is active",
    "banned" => "User is banned",
    _ => "Unknown status"
};

// Pattern matching
var category = number switch
{
    > 0 and < 10 => "Single digit",
    >= 10 and < 100 => "Double digit",
    _ => "Other"
};
```

## Loops

```csharp
// For
for (int i = 0; i < items.Count; i++) {
    Console.WriteLine(items[i]);
}

// Foreach
foreach (var item in items) {
    Console.WriteLine(item);
}

// While
while (retryCount < 3) {
    if (TryConnect()) break;
    retryCount++;
}
```

## Early Exit

```csharp
void Process(string? input)
{
    if (string.IsNullOrWhiteSpace(input)) return;
    if (input.Length < 3) return;
    // process
}
```

---

**Next:** [Methods & Classes](03-methods-and-classes.md)
