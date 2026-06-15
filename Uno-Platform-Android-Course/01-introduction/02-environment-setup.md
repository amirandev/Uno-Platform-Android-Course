# Environment Setup

## Required Software

### 1. .NET SDK 9.0+

```
dotnet --version
```

Install from [dotnet.microsoft.com](https://dotnet.microsoft.com/download)

### 2. Visual Studio 2022+

Install with workloads:
- **Mobile development with .NET** (includes Android SDK)
- **ASP.NET and web development** (optional)

### 3. Android SDK

Installed via Visual Studio or standalone from [developer.android.com](https://developer.android.com/studio)

Check your SDK path:
```
echo $ANDROID_HOME
```

### 4. Uno Platform Templates

```powershell
dotnet new install Uno.Templates
```

Verify:
```powershell
dotnet new list | Select-String uno
```

### 5. Create Your First Project

```powershell
dotnet new unoapp -n MyApp -o MyApp -platforms android
cd MyApp/MyApp
dotnet build
```

## Android Emulator

### Create an AVD

Using Android Studio AVD Manager or command line:
```powershell
avdmanager create avd -n Pixel_9 -k "system-images;android-35;google_apis;x86_64"
```

### Run your app

```powershell
dotnet build -t:Run
```

---

**Next:** [Your First App](03-first-app.md)
