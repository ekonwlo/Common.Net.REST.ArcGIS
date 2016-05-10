using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS.Geocode
{
	using Attributes;
	using Content;

	public class ArcGisReverseGeocodeResponse
		: ArcGisResponse
	{
		[RestContent("content")]
		public ArcGisReverseGeocodeResponseContent Content { get; internal set; }

		private ArcGisReverseGeocodeResponse() : base() { }
	}
}
