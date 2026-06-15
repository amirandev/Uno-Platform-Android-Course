# What is Uno Platform?

Uno Platform lets you write a single codebase in **C# and WinUI/XAML** and deploy to **Android, iOS, WebAssembly, macOS, Linux, and Windows**.

## Why Uno for Android?

- **Write once, run anywhere** — Share ~100% of your code across platforms
- **WinUI 3 API** — Use the same controls and patterns as Windows app development
- **Native performance** — Skia renderer or native renderer options
- **Full OSS** — MIT licensed, active community
- **C# ecosystem** — Use NuGet packages, .NET libraries, existing C# code

## How it Works

```
C# + XAML (WinUI)
         |
    Uno Platform
         |
    ┌────┴────┐
 Android     iOS/Web/Desktop
```

Uno translates your WinUI XAML and C# into native Android views (native mode) or renders with Skia (skia mode).

## What You'll Build

Throughout this course, you'll build:
- Login screens
- Data-driven list pages
- Apps using camera, GPS, and sensors
- Full CRUD applications with SQLite
- REST API clients with auth
- Published apps for Google Play

---

**Next:** [Environment Setup](02-environment-setup.md)
