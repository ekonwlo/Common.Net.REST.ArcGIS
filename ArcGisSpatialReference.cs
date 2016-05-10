using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

  //  // "wkid": 4326,
  // "latestWkid": 4326
	public class ArcGisSpatialReference
	{
		[RestContent("wkid")]
		public int Wkid { get; set; }

		[RestContent("latestWkid")]
		public int LatestWkid { get; set; }

		private ArcGisSpatialReference() { }
	}
}
