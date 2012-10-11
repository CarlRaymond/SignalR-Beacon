using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
	public class LocationReport
	{
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public int Accuracy { get; set; }
		public DateTime Timestamp { get; set; }
		public string ID { get; set; }
	}
}