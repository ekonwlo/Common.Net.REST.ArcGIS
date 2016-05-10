using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

	public sealed class ArcGisOAuth2TokenResponse
		: ArcGisResponse
	{

		[RestContent("content")]
		public ArcGisOAuth2TokenResponseContent Content { get; internal set; }
		
		private ArcGisOAuth2TokenResponse() : base() { }
	}
}
