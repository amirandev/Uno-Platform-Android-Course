# Real-time Communication

## WebSockets

```csharp
public class ChatService
{
    private ClientWebSocket? _ws;

    public async Task ConnectAsync(string url, string token)
    {
        _ws = new ClientWebSocket();
        _ws.Options.SetRequestHeader("Authorization", $"Bearer {token}");
        await _ws.ConnectAsync(new Uri(url), CancellationToken.None);
        _ = ReceiveLoopAsync();
    }

    async Task ReceiveLoopAsync()
    {
        var buffer = new byte[8192];
        while (_ws?.State == WebSocketState.Open)
        {
            var result = await _ws.ReceiveAsync(
                new ArraySegment<byte>(buffer), CancellationToken.None);
            if (result.MessageType == WebSocketMessageType.Close)
                break;
            var text = Encoding.UTF8.GetString(buffer, 0, result.Count);
            // Handle message...
        }
    }

    public async Task SendAsync(string message)
    {
        var data = Encoding.UTF8.GetBytes(message);
        await _ws!.SendAsync(new ArraySegment<byte>(data),
            WebSocketMessageType.Text, true, CancellationToken.None);
    }

    public async Task DisconnectAsync()
    {
        if (_ws?.State == WebSocketState.Open)
            await _ws.CloseAsync(WebSocketCloseStatus.NormalClosure,
                "User disconnected", CancellationToken.None);
    }
}
```

## SignalR (Higher Level)

```csharp
// Install Microsoft.AspNetCore.SignalR.Client
var connection = new HubConnectionBuilder()
    .WithUrl("https://api.example.com/chat")
    .Build();

connection.On<string>("ReceiveMessage", (message) =>
{
    // Update UI
});

await connection.StartAsync();
await connection.InvokeAsync("SendMessage", "Hello world");
```

## Polling (Simple)

```csharp
async Task PollAsync(CancellationToken ct)
{
    while (!ct.IsCancellationRequested)
    {
        var data = await _api.GetLatestAsync();
        // Update UI
        await Task.Delay(5000, ct);
    }
}
```

## Push Notifications

Firebase Cloud Messaging (FCM) is the standard for Android push notifications. Uno supports it via platform-specific implementations.

---

**Next:** [Module 9 — Device Features](../09-device-features/01-camera-and-gallery.md)
