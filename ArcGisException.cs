using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common.Net.REST;

namespace Common.Net.REST.ArcGIS
{
	using Attributes;
	using Content;

	public class ArcGisException
		: RestException
	{

		[RestContent("content")]
		public ArcGisExcpetionContent Content { get; private set; }

		protected internal ArcGisException()
			: base()
		{ }

		protected internal ArcGisException(string message)
			: base(message)
		{ }

		protected internal ArcGisException(string message, Exception innerException)
			: base(message, innerException)
		{ }

		protected internal ArcGisException(SerializationInfo info, StreamingContext context)
			: base()
		{ }

		//public override string ToString()
		//{
		//	if (Content == null)
		//		return base.ToString();

		//	return string.Format("B2Excepton: {0} ({1}) - {2}", Content.Code, Content.Status, Content.Message);
		//}
	}
}
