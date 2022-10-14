using System;
using Microsoft.AspNetCore.SignalR;
namespace SignalRBackend.Hubs
{
    public class ActivityImportHub : Hub
    {
        public Task Register() =>
    Clients.Client(Context.ConnectionId)
           .SendAsync("onRegister", true);
    }
}

