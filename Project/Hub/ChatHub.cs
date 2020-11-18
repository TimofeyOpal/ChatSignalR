using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Project
{
    
   
    public class ChatHub : Hub
    {
        
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("newMessage", Context.User.Identity.Name, message);
        }
    }
}