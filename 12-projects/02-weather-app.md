# Project 2: Weather App

Build a weather app using a free REST API (OpenWeatherMap or WeatherAPI).

## Features

- Current weather by city or GPS
- 7-day forecast
- Search cities with AutoSuggestBox
- Weather icons based on conditions
- Pull-to-refresh

## Architecture

```
Services/WeatherApi.cs
Models/WeatherData.cs
ViewModels/WeatherViewModel.cs
Screens/WeatherPage.xaml / .cs
Converters/WeatherIconConverter.cs
```

## API Setup (Free)

```csharp
public class WeatherApi
{
    private readonly HttpClient _http;
    private const string ApiKey = "YOUR_API_KEY";

    public WeatherApi(HttpClient http) => _http = http;

    public async Task<WeatherResponse?> GetCurrentAsync(string city)
    {
        var url = $"https://api.weatherapi.com/v1/current.json" +
                  $"?key={ApiKey}&q={city}&aqi=no";
        var response = await _http.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsync<WeatherResponse>();
    }

    public async Task<ForecastResponse?> GetForecastAsync(string city, int days = 7)
    {
        var url = $"https://api.weatherapi.com/v1/forecast.json" +
                  $"?key={ApiKey}&q={city}&days={days}";
        var response = await _http.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsync<ForecastResponse>();
    }
}
```

## UI Layout

```
┌─────────────────────────┐
│ 🔍 Search city...       │  ← AutoSuggestBox
├─────────────────────────┤
│                         │
│         ☀️              │
│       72°F              │  ← Current weather card
│    Sunny                │
│   H: 80° L: 65°        │
│                         │
├─────────────────────────┤
│ Mon  ☀️ 72°  │ Tue 🌤️ 70°│
│ Wed  🌧️ 68° │ Thu ☀️ 75°│  ← 7-day forecast grid
│ Fri  ☁️ 70° │ Sat 🌤️ 73°│
│ Sun  ☀️ 78°            │
└─────────────────────────┘
```

## Learning Outcomes

- REST API integration with HttpClient
- JSON deserialization with System.Text.Json
- Location services (GPS)
- Pull-to-refresh (RefreshContainer)
- Dynamic icons with converters
- Error handling & loading states

---

**Next:** [Chat App](03-chat-app.md)
