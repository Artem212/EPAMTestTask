using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalRChatHost.DataBase;

namespace SignalRChatHost
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        
        public void SendMessage(string clientName, string message)
        {
            if (LogsManager.AddLog(clientName, DateTime.Now, message) == 0)
                Clients.All.addMessage(clientName+ ": "+ message);
            else
                Clients.Caller.showErrorMessage();         
        }
    }
}

