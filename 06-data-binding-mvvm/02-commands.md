# Commands

Commands replace click event handlers — they bind buttons to ViewModel methods.

## ICommand Interface

```csharp
public interface ICommand
{
    void Execute(object? parameter);
    bool CanExecute(object? parameter);
    event EventHandler? CanExecuteChanged;
}
```

## RelayCommand

```csharp
public class RelayCommand : ICommand
{
    private readonly Action<object?> _execute;
    private readonly Func<object?, bool>? _canExecute;

    public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public void Execute(object? parameter) => _execute(parameter);
    public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

    public event EventHandler? CanExecuteChanged;
    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}
```

## AsyncRelayCommand

```csharp
public class AsyncRelayCommand : ICommand
{
    private readonly Func<Task> _execute;
    private bool _isExecuting;

    public AsyncRelayCommand(Func<Task> execute) => _execute = execute;

    public async void Execute(object? parameter)
    {
        if (_isExecuting) return;
        _isExecuting = true;
        RaiseCanExecuteChanged();
        await _execute();
        _isExecuting = false;
        RaiseCanExecuteChanged();
    }

    public bool CanExecute(object? parameter) => !_isExecuting;
    public event EventHandler? CanExecuteChanged;
    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}
```

## Using Commands in ViewModel

```csharp
public class LoginViewModel
{
    public ICommand LoginCommand { get; }
    public ICommand ForgotPasswordCommand { get; }

    public LoginViewModel()
    {
        LoginCommand = new AsyncRelayCommand(LoginAsync);
        ForgotPasswordCommand = new RelayCommand(_ => OpenForgotPassword());
    }

    async Task LoginAsync()
    {
        IsLoading = true;
        // ... login logic
        IsLoading = false;
    }

    void OpenForgotPassword() { }
}
```

## Binding in XAML

```xml
<Button Content="Login" Command="{Binding LoginCommand}" />
<Button Content="Cancel" Command="{Binding CancelCommand}" />

<!-- With parameter -->
<Button Content="Delete" Command="{Binding DeleteCommand}"
        CommandParameter="item42" />
```

## Toolkit Community

Install `CommunityToolkit.Mvvm` for source-generated commands:

```csharp
[RelayCommand]
async Task LoginAsync() { }
```

This auto-generates the `LoginCommand` property.

---

**Next:** [MVVM Pattern](03-mvvm-pattern.md)
