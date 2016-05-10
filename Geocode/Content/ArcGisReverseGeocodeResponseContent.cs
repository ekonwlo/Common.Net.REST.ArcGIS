using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS.Geocode.Content
{
	using Attributes;

	public class ArcGisReverseGeocodeResponseContent
	{
		[RestContent("address")]
		public ArcGisAddress Address { get; internal set; }

		[RestContent("location")]
		public ArcGisLocation Location { get; internal set; }

		[RestContent("error", Mandatory = false)]
		public ArcGisError Error { get; internal set; }

		private ArcGisReverseGeocodeResponseContent() { }
	}
}
