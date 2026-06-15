# Native Interop (Advanced)

## Calling Java/Kotlin Libraries

```csharp
#if __ANDROID__
using Android.App;
using Android.Gms.Maps;

public class MapService
{
    public void ShowMap(Activity activity)
    {
        var mapFragment = MapFragment.NewInstance();
        activity.FragmentManager.BeginTransaction()
            .Add(Android.Resource.Id.Content, mapFragment)
            .Commit();
    }
}
#endif
```

## Binding AAR Libraries

1. Create a **Android Java Bindings Library** project
2. Add the `.aar` file
3. Build outputs C# wrappers for Java classes
4. Reference from your Uno project

## P/Invoke (Native C Libraries)

```csharp
[DllImport("native_lib.so")]
static extern int native_function(int param);
```

## Platform Service Pattern

```csharp
public interface ITextToSpeech
{
    Task SpeakAsync(string text);
}

#if __ANDROID__
public class TtsService : ITextToSpeech
{
    public async Task SpeakAsync(string text)
    {
        var ctx = Android.App.Application.Context;
        var tts = new Android.Speech.Tts.TextToSpeech(ctx, null!);
        tts.Speak(text, Android.Speech.Tts.QueueMode.Flush, null, null);
    }
}
#endif

// Register in DI
#if __ANDROID__
services.AddSingleton<ITextToSpeech, TtsService>();
#endif
```

---

**Next:** [Module 11 — Publishing](../11-publishing/01-app-signing.md)
