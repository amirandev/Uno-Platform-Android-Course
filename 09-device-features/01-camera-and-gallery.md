# Camera & Gallery

## Taking a Photo

```csharp
async Task TakePhotoAsync()
{
    var photo = await MediaPicker.CapturePhotoAsync();
    if (photo is null) return;

    // Save to app storage
    var localFolder = ApplicationData.Current.LocalFolder;
    var file = await photo.CopyAsync(
        localFolder, $"photo_{DateTime.Now:yyyyMMdd_HHmmss}.jpg");

    // Display
    using var stream = await file.OpenReadAsync();
    // Set as Image source
}
```

## Picking from Gallery

```csharp
async Task PickPhotoAsync()
{
    var result = await MediaPicker.PickPhotoAsync();
    if (result is null) return;

    // Display selected photo
    var bitmap = new BitmapImage();
    using var stream = await result.OpenReadAsync();
    await bitmap.SetSourceAsync(stream);
    MyImage.Source = bitmap;
}
```

## Permissions

```csharp
async Task<bool> RequestCameraPermissionAsync()
{
    var status = await Permissions.RequestAsync<Permissions.Camera>();
    if (status != PermissionStatus.Granted)
    {
        await new ContentDialog
        {
            Title = "Permission Required",
            Content = "Camera access is needed to take photos.",
            PrimaryButtonText = "OK"
        }.ShowAsync();
        return false;
    }
    return true;
}
```

## Android Manifest

```xml
<!-- Required permissions added automatically by Uno -->
<uses-permission android:name="android.permission.CAMERA" />
<uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />
<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
```

---

**Next:** [Location & GPS](02-location-gps.md)
