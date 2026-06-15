# Hot Reload — Live Preview

Edit XAML/C# and see changes instantly on the emulator — no full rebuild needed.

## Visual Studio (Simplest)

1. Install the **Uno Platform Extension** for Visual Studio
2. Run your app in **Debug** mode
3. Edit any `.xaml` file, press **Ctrl+S** — UI updates live on the device

## CLI Remote Control

```powershell
dotnet build -t:Run -p:UnoRemoteControl=true
```

## What Reloads

| Change | Works? |
|--------|--------|
| XAML layout, styles, colors | ✅ |
| C# method bodies | ✅ |
| New classes/properties | ⚠️ Partial |
| NuGet packages / .csproj | ❌ Rebuild |

The emulator stays running — just save and see results instantly.
