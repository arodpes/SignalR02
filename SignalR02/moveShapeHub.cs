using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR02
{
    [HubName("moveShape")]
    public class moveShapeHub : Hub
    {
        public void moveShape(int x, int y)
        {
            Clients.Others.ShapeMoved(x, y);
        }
    }
}