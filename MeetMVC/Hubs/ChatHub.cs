using System;
using Microsoft.AspNet.SignalR;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace MeetMVC.Hubs
{
    public class ChatHub : Hub
    {

        public void Send(string username, string message)
        {
            Clients.All.addNewMessageToPage(username, message);
        }

    }
}
