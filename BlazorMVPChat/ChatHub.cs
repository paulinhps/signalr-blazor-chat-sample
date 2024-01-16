using Microsoft.AspNetCore.SignalR;

public sealed class ChatHub : Hub
{
    public async Task SendMessage(string user, string message) {

       await Clients.All.SendAsync("ReceiveMessage", user, message);

    }
}