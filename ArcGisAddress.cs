using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

	public class ArcGisAddress
	{
		[RestContent("Address")]
		public string Address { get; internal set; }

		[RestContent("Neighborhood")]
		public string Neighborhood { get; internal set; }

		[RestContent("City")]
		public string City { get; internal set; }

		[RestContent("Subregion")]
		public string Subregion { get; internal set; }

		[RestContent("Region")]
		public string Region { get; internal set; }

		[RestContent("Postal")]
		public string Postal { get; internal set; }

		[RestContent("PostalExt")]
		public string PostalExt { get; internal set; }

		[RestContent("CountryCode")]
		public string CountryCode { get; internal set; }

		[RestContent("Match_addr")]
		public string MatchAddress { get; internal set; }

		[RestContent("Loc_name")]
		public string LocalName { get; internal set; }
		
		private ArcGisAddress() { }
	}
}
