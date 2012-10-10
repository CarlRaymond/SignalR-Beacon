using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace Website.Hubs
{
	public class Tracker : Hub
	{
		public void Send(string message)
		{
			Clients.addMessage(message);
		}
	}
}