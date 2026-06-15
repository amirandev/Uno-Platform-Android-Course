# Building APK

## Debug Build

```powershell
dotnet build -f net9.0-android -c Debug
```

## Release Build

```powershell
dotnet publish -f net9.0-android -c Release
```

## AAB (Android App Bundle)

Google Play requires AAB format for new apps:

```powershell
dotnet publish -f net9.0-android -c Release `
    -p:AndroidPackageFormat=aab
```

## APK vs AAB

| Format | Use | Size |
|--------|-----|------|
| APK | Direct install, sideloading | Full app size |
| AAB | Google Play Store | ~ Smaller (dynamic delivery) |

## Output Locations

```
Debug:  bin\Debug\net9.0-android\com.companyname.app-Signed.apk
Release: bin\Release\net9.0-android\com.companyname.app-Signed.apk
AAB:     bin\Release\net9.0-android\com.companyname.app-Signed.aab
```

## Install Directly

```powershell
adb install bin\Release\net9.0-android\com.companyname.app-Signed.apk
```

## Versioning

```xml
<PropertyGroup>
    <ApplicationDisplayVersion>1.0.0</ApplicationDisplayVersion>
    <ApplicationVersion>1</ApplicationVersion>
</PropertyGroup>
```

---

**Next:** [Google Play Store](03-google-play-store.md)
