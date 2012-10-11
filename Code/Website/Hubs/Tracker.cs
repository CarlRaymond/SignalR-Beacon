using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;
using Website.Models;

namespace Website.Hubs
{
	public class Tracker : Hub
	{
		public void SendMessage(string message)
		{
			string id = Context.ConnectionId;
			Clients.addMessage(message, id);
		}

		public void SendLocation(LocationReport rep)
		{
			rep.Timestamp = DateTime.Now;
			rep.ID = Context.ConnectionId;
			Clients.locationUpdate(rep);
		}
	}
}