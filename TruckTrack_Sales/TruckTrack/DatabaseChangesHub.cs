using Microsoft.AspNetCore.SignalR;

namespace TruckTrack
{
    public class DatabaseChangesHub:Hub
    {
        public async Task NotifyDatabaseChange()
        {
            await Clients.All.SendAsync("ReloadPage"); // Broadcast a notification to all connected clients
        }
    }
}
