using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DataAccess.Hubs
{
    public class MessagesHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        [HubMethodName("updateAllStoresData")]
        public static void SendAllStoresByHourChange()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MessagesHub>();
            context.Clients.All.updateMessages();
        }

        [HubMethodName("updateStoreByHour")]
        public static void SendStoreByHourChange()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MessagesHub>();
            context.Clients.All.updateMessages();
        }


        [HubMethodName("totalSalesByStore")]
        public static void TotalSalesByStore()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MessagesHub>();
            context.Clients.All.updateMessages();
        }


    }
}