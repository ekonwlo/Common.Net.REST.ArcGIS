using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

	[RestRequest("sharing/rest/oauth2/token", Method = WebRequestMethods.Http.Post)]
	public class ArcGisOAuth2TokenRequest
		: ArcGisRequest<ArcGisOAuth2TokenResponse>
	{
		[RestUrlParameter("client_id")]
		public string ClientId { get; set; }

		[RestUrlParameter("client_secret")]
		public string ClientSecret { get; set; }

		[RestUrlParameter("grant_type")]
		public string GrantType { get; set; }

		[RestUrlParameter("expiration")]
		public int Expiration { get; set; }

		[RestUrlParameter("f")]
		public string Format { get; set; }
		
		private ArcGisOAuth2TokenRequest() : base() { }
	}
}
