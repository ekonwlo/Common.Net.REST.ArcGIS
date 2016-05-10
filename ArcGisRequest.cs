using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

	[RestCharset(RestContentEncodings.UTF8)]
	[RestApplication(RestContentApplicationTypes.JSON)]
	public abstract class ArcGisRequest<T>
		: RestRequest<T> where T : ArcGisResponse
	{
	}
}
