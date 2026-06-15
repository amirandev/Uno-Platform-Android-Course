# App Signing

## Generate a Keystore

```powershell
keytool -genkey -v -keystore myapp.keystore `
    -alias myalias -keyalg RSA -keysize 2048 `
    -validity 10000
```

You'll be prompted for:
- Keystore password
- Key password
- Name, org, location details

## Configure .csproj for Signing

```xml
<PropertyGroup>
    <AndroidSigningKeyStore>..\myapp.keystore</AndroidSigningKeyStore>
    <AndroidSigningKeyAlias>myalias</AndroidSigningKeyAlias>
    <AndroidSigningKeyPass>your_key_password</AndroidSigningKeyPass>
    <AndroidSigningStorePass>your_store_password</AndroidSigningStorePass>
</PropertyGroup>
```

## Build Signed APK

```powershell
dotnet publish -f net9.0-android -c Release
```

Output will be a signed APK at:
```
bin\Release\net9.0-android\com.companyname.myapp-Signed.apk
```

## Keystore Security

- **Never commit** keystore or passwords to git
- Use environment variables or CI secrets:
```xml
<AndroidSigningKeyPass>$(ANDROID_KEY_PASS)</AndroidSigningKeyPass>
```

---

**Next:** [Building APK](02-building-apk.md)
