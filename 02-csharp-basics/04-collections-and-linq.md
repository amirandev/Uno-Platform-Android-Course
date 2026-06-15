# Collections & LINQ

## Common Collections

```csharp
// List (most common in mobile)
var names = new List<string> { "Alice", "Bob", "Charlie" };
names.Add("Diana");
names.Remove("Bob");

// Dictionary
var scores = new Dictionary<string, int>
{
    ["Alice"] = 95,
    ["Bob"] = 87
};
if (scores.TryGetValue("Alice", out var score)) { }

// ObservableCollection (for UI binding)
var items = new ObservableCollection<string>();
items.Add("New Item");  // UI updates automatically
```

## LINQ (Querying Collections)

```csharp
var users = new List<User> { /* ... */ };

// Method syntax
var adults = users
    .Where(u => u.Age >= 18)
    .OrderBy(u => u.Name)
    .Select(u => u.Name)
    .ToList();

// Query syntax
var result = from u in users
             where u.Age >= 18
             orderby u.Name
             select u.Name;
```

## Common LINQ Operations

```csharp
var first = items.FirstOrDefault();       // First or null
var exists = items.Any(x => x.Length > 5); // Check condition
var count = items.Count(x => x.IsActive);  // Count matches
var max = scores.Max();                    // Max value
var grouped = items.GroupBy(x => x.Type);  // Grouping
var distinct = items.Distinct();           // Unique values
```

## In Mobile Apps

Collections are everywhere in mobile dev — lists of users, products, messages, settings. `ObservableCollection<T>` is your best friend for UI-bound lists.

---

**Next:** [Async/Await](05-async-await.md)
