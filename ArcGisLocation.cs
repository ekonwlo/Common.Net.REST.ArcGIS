using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

	public class ArcGisLocation
	{
		[RestContent("x")]
		public double X { get; internal set; }

		[RestContent("y")]
		public double Y { get; internal set; }

		[RestContent("spatialReference", Mandatory = false)]
		public ArcGisSpatialReference SpatialReference { get; internal set; }

		public ArcGisLocation() { }

		public ArcGisLocation(double x, double y)
		{
			X = x;
			Y = y;
		}

	}
}
