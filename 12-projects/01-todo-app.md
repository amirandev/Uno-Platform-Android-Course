# Project 1: Todo App

Build a full CRUD Todo app using SQLite + MVVM.

## Features

- Add/Edit/Delete todos
- Mark as complete
- Filter: All, Active, Completed
- Persist with SQLite
- Dark mode toggle

## Architecture

```
Models/TodoItem.cs
Services/DatabaseService.cs
ViewModels/TodoViewModel.cs
Screens/HomePage.xaml / .cs
Partials/TodoItemTemplate.xaml
```

## Key Implementation

```csharp
[Table("todos")]
public class TodoItem
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
```

```csharp
[RelayCommand]
async Task ToggleCompleteAsync(TodoItem item)
{
    item.IsCompleted = !item.IsCompleted;
    await _db.SaveAsync(item);
}

[RelayCommand]
async Task DeleteAsync(TodoItem item)
{
    await _db.DeleteAsync(item);
    Todos.Remove(item);
}
```

## UI Structure

```
┌─────────────────────┐
│  ✅ My Todos    [+] │  ← Header + Add button
├─────────────────────┤
│ 📋 All │ 🔥 Active │  ← Filter chips
│ ✅ Completed       │
├─────────────────────┤
│ ☐ Buy groceries    │
│ ☑ Finish homework  │  ← List with checkboxes
│ ☐ Call mom         │
├─────────────────────┤
│ 3 items     2 done  │  ← Footer stats
└─────────────────────┘
```

## Learning Outcomes

- SQLite CRUD operations
- ObservableCollection + ListView
- Data binding with commands
- Filtering with CollectionViewSource
- UI state management

---

**Next:** [Weather App](02-weather-app.md)
