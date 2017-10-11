using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashboardSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void SendAll(Message msg)
        {
            Clients.All.broadCastMessage(msg);
        }

        public void SendToGroup(Message msg)
        {
            Clients.Group(msg.group, Context.ConnectionId).broadCastMessage(msg);
        }

        public void SendToClient(Message msg)
        {
            Clients.Group(msg.group, Context.ConnectionId).broadCastMessage(msg);
        }
    }

    public class Message
    {
        public string name { get; set; }
        public string message { get; set; }
        public string group { get; set; }
    }
}