using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Common.Net.REST.ArcGIS.Geocode.Transformation
{
	using Runtime.Serialization.Transformation;

	class LocationTransformation
		: IRestTransformation<ArcGisLocation, string>
	{
		


		public ArcGisLocation Revert(string input)
		{
			throw new NotImplementedException();
		}

		public string Transform(ArcGisLocation input)
		{
			return string.Format(ArcGisGlobal.CultureInfo, "{{ \"x\"={0}, \"y\"={1} }}", input.X, input.Y);
		}
	}
}
