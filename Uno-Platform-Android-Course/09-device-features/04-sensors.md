# Sensors

## Accelerometer

```csharp
var accelerometer = Accelerometer.GetDefault();
if (accelerometer is not null)
{
    accelerometer.ReadingChanged += (s, e) =>
    {
        var reading = e.Reading;
        var x = reading.AccelerationX;
        var y = reading.AccelerationY;
        var z = reading.AccelerationZ;
    };
    accelerometer.ReportInterval = 16; // ~60 FPS
}
```

## Gyrometer

```csharp
var gyrometer = Gyrometer.GetDefault();
if (gyrometer is not null)
{
    gyrometer.ReadingChanged += (s, e) =>
    {
        var reading = e.Reading;
        var x = reading.AngularVelocityX;
        var y = reading.AngularVelocityY;
        var z = reading.AngularVelocityZ;
    };
}
```

## Compass

```csharp
var compass = Compass.GetDefault();
if (compass is not null)
{
    compass.ReadingChanged += (s, e) =>
    {
        var heading = e.Reading.HeadingMagneticNorth;
    };
}
```

## Light Sensor

```csharp
var lightSensor = LightSensor.GetDefault();
if (lightSensor is not null)
{
    lightSensor.ReadingChanged += (s, e) =>
    {
        var lux = e.Reading.IlluminanceInLux;
    };
}
```

## Using Sensors Responsibly

```csharp
// Start/Stop pattern
private Accelerometer? _accelerometer;

void StartTracking()
{
    _accelerometer = Accelerometer.GetDefault();
    if (_accelerometer is not null)
    {
        _accelerometer.ReadingChanged += OnAccelerometerReading;
        _accelerometer.ReportInterval = 16;
    }
}

void StopTracking()
{
    if (_accelerometer is not null)
    {
        _accelerometer.ReadingChanged -= OnAccelerometerReading;
    }
}

// Called from OnNavigatedTo / OnNavigatedFrom
protected override void OnNavigatedTo(NavigationEventArgs e) => StartTracking();
protected override void OnNavigatedFrom(NavigationEventArgs e) => StopTracking();
```

---

**Next:** [Sharing & Intents](05-sharing-and-intents.md)
