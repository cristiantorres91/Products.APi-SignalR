using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.APi.Hubs
{
    public class ProductHub : Hub
    {
        public async Task SendMyEvent()
        {
            await Clients.All.SendAsync("AddProduct");
        }
    }
}
