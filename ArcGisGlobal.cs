using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Common.Net.REST.ArcGIS
{
	sealed class ArcGisGlobal
	{
		private static readonly CultureInfo _cultureInfo;

		public static CultureInfo CultureInfo
		{ 
			get
			{
				return _cultureInfo;
			}
		}

		static ArcGisGlobal()
		{
			_cultureInfo = new CultureInfo("en-US");

		}

	}
}
