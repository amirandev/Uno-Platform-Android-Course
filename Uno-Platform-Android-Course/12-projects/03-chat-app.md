# Project 3: Chat App

Build a real-time chat app using WebSockets.

## Features

- Real-time messaging via WebSockets
- User authentication (JWT)
- Chat rooms / direct messages
- Message timestamps
- Typing indicators
- Online/offline status

## Architecture

```
Services/AuthService.cs
Services/ChatService.cs
Models/Message.cs, User.cs
ViewModels/ChatViewModel.cs
Screens/LoginPage.xaml / .cs
Screens/ChatListPage.xaml / .cs
Screens/ChatRoomPage.xaml / .cs
Templates/MessageTemplateSelector.cs
```

## WebSocket Chat Service

```csharp
public class ChatService
{
    private ClientWebSocket? _ws;
    public event Action<Message>? OnMessageReceived;

    public async Task ConnectAsync(string token)
    {
        _ws = new ClientWebSocket();
        _ws.Options.SetRequestHeader("Authorization", $"Bearer {token}");
        await _ws.ConnectAsync(new Uri("wss://api.example.com/chat"), default);
        _ = ReceiveLoopAsync();
    }

    async Task ReceiveLoopAsync()
    {
        var buffer = new byte[8192];
        while (_ws?.State == WebSocketState.Open)
        {
            var result = await _ws.ReceiveAsync(
                new ArraySegment<byte>(buffer), default);
            if (result.MessageType == WebSocketMessageType.Close) break;
            var json = Encoding.UTF8.GetString(buffer, 0, result.Count);
            var msg = JsonSerializer.Deserialize<Message>(json);
            if (msg is not null) OnMessageReceived?.Invoke(msg);
        }
    }

    public async Task SendAsync(Message message)
    {
        var json = JsonSerializer.Serialize(message);
        var data = Encoding.UTF8.GetBytes(json);
        await _ws!.SendAsync(new ArraySegment<byte>(data),
            WebSocketMessageType.Text, true, default);
    }
}
```

## UI

- Message bubbles (incoming/outgoing with DataTemplateSelector)
- Chat list with last message preview
- Typing indicator (... animation)
- Pull to load older messages

## Learning Outcomes

- Real-time communication with WebSockets
- SignalR integration
- JWT authentication flow
- DataTemplateSelector for different item layouts
- Infinite scroll / pagination

---

**Next:** [E-commerce App](04-ecommerce-app.md)
