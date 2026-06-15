# Uno Platform Project Structure

## Anatomy of a Project

```
MyApp/
├── MyApp.sln
└── MyApp/
    ├── App.xaml / .cs           # App entry, window setup
    ├── MainPage.xaml / .cs      # Default landing page
    ├── GlobalUsings.cs          # Shared usings
    ├── SampleApp.csproj         # SDK = Uno.Sdk
    ├── app.manifest             # Android manifest XML
    ├── Package.appxmanifest     # Windows manifest (ignored on Android)
    ├── Assets/
    │   ├── Icons/               # App launcher icons
    │   └── Splash/              # Splash screen images
    ├── Platforms/
    │   └── Android/
    │       ├── AndroidManifest.xml  # Merged manifest entries
    │       ├── MainActivity.cs      # Android Activity
    │       └── MainApplication.cs   # Android Application class
    ├── Strings/                 # Localized string resources
    └── Properties/
```

## The .csproj File

```xml
<Project Sdk="Uno.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net9.0-android</TargetFrameworks>
    <OutputType>Exe</OutputType>
    <ApplicationTitle>MyApp</ApplicationTitle>
    <ApplicationId>com.mycompany.myapp</ApplicationId>
    <UnoFeatures>SkiaRenderer</UnoFeatures>
  </PropertyGroup>
</Project>
```

Key properties:
- **TargetFrameworks** — Which platforms you target
- **ApplicationId** — Your app's unique identifier (like a package name)
- **UnoFeatures** — Enable features like SkiaRenderer, Lottie, SVG

## The Single Project Model

Uno uses **UnoSingleProject** — one .csproj handles all platforms. Platform-specific code goes in `#if __ANDROID__` blocks or the `Platforms/` folder.

---

**Next:** [Module 2 — C# Basics](../02-csharp-basics/01-variables-and-types.md)
