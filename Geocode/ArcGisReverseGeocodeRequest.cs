using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.ArcGIS.Geocode
{
	using Attributes;
	using Runtime.Serialization.Attributes;
	using Transformation;

	[RestException(typeof(ArcGisException))]
	[RestRequest("arcgis/rest/services/World/GeocodeServer/reverseGeocode", Method = WebRequestMethods.Http.Post)]
	public class ArcGisReverseGeocodeRequest
		: ArcGisRequest<ArcGisReverseGeocodeResponse>
	{
		[RestUrlParameter("location")]
		[PropertyTransformation(typeof(LocationTransformation))]
		public ArcGisLocation Location { get; set; }

		[RestUrlParameter("token")]
		public string Token { get; set; }

		[RestUrlParameter("f")]
		public string Format { get; set; }

		[RestUrlParameter("distance", Mandatory = false)]
		public int? Distance { get; set; }

		[RestUrlParameter("outSR", Mandatory = false)]
		public int? OutSpatialReference { get; set; }

		[RestUrlParameter("langCode", Mandatory = false)]
		public string LanguageCode { get; set; }

		[RestUrlParameter("returnIntersection", Mandatory = false)]
		public bool? ReturnIntersection { get; set; }

		private ArcGisReverseGeocodeRequest() : base() { }
	}
}
