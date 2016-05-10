using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;

	//   {
	//	   {
	//		"code": 400,
	//		"message": "Unable to complete operation.",
	//		"details": [ ]
	//}

	public class ArcGisError
	{
		[RestContent("code")]
		public int Code { get; internal set; }

		[RestContent("message")]
		public string Message { get; internal set; }

		[RestContent("details")]
		public string[] Details { get; internal set; }

		private ArcGisError() { }
	}
}
