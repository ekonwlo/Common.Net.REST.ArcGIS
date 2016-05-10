using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.ArcGIS.Content
{
	using Attributes;

	public class ArcGisExcpetionContent
	{
		[RestContent("error")]
		public ArcGisError Error { get; internal set; }

		private ArcGisExcpetionContent() { }
	}
}
