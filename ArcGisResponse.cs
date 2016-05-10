using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

	public abstract class ArcGisResponse
		: RestResponse
	{
		internal protected ArcGisResponse() : base() { }
	}
}
