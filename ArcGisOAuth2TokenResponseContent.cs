using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;
	
	//	{
	//		"access_token": "xJvwJJ6TDTYbjkNXupxwS2ZDASTkovsAu_REShwV7ptx98-8gqviOcJkWBYAf5VGZm6itDJ1RHuSH1c1kvZKIPUrsuNcTrkasyFN0GkvVX6PUqGlSpLHUXIln6C5TZfvT7Tb6rr5ko9pZ5Ej_zrChg..",
	//		"expires_in": 86400
	//	}
	public sealed class ArcGisOAuth2TokenResponseContent
	{

		[RestContent("access_token")]
		public string AccessToken { get; internal set; }

		[RestContent("expires_in")]
		public int ExpiresIn { get; internal set; }
		
		private ArcGisOAuth2TokenResponseContent() { }
	}
}
