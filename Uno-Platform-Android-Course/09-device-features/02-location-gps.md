# Location & GPS

## Getting Current Location

```csharp
public class LocationService
{
    public async Task<(double Lat, double Lng)?> GetCurrentLocationAsync()
    {
        var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
        if (status != PermissionStatus.Granted)
            return null;

        var geoLocator = new Geolocator
        {
            DesiredAccuracy = PositionAccuracy.Default
        };
        var position = await geoLocator.GetGeopositionAsync(
            TimeSpan.FromMinutes(1), TimeSpan.FromSeconds(30));

        return (position.Coordinate.Latitude, position.Coordinate.Longitude);
    }
}
```

## Reverse Geocoding (Address → Coordinates)

```csharp
// Use MapLocationFinder from Windows.Services.Maps
var query = "1600 Amphitheatre Parkway, Mountain View, CA";
var result = await MapLocationFinder.FindLocationsAsync(query, null);
if (result.Status == MapLocationFinderStatus.Success)
{
    var location = result.Locations.FirstOrDefault();
    var point = location?.Point;
    // Use point.Position.Latitude / Longitude
}
```

## Tracking Location Changes

```csharp
var geoLocator = new Geolocator
{
    ReportInterval = 5000, // ms
    MovementThreshold = 10 // meters
};
geoLocator.PositionChanged += (s, e) =>
{
    var pos = e.Position;
    // Update UI with new position
};
```

## Location Permissions

Android manifest:
```xml
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
```

---

**Next:** [Notifications](03-notifications.md)
