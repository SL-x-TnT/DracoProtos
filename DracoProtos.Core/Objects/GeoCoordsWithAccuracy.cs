using System;
using DracoProtos.Core.Base;
using DracoProtos.Core.Extensions;

namespace DracoProtos.Core.Objects
{
	public class GeoCoordsWithAccuracy : GeoCoordsWithAccuracyBase
	{
		public static GeoCoordsWithAccuracy of(Coordinates coordinates)
		{
			if (coordinates == null)
			{
				return GeoCoordsWithAccuracy.UNKNOWN;
			}
			GeoCoordsWithAccuracy geoCoordsWithAccuracy = new GeoCoordsWithAccuracy();
			geoCoordsWithAccuracy.latitude = coordinates.latitude;
			geoCoordsWithAccuracy.longitude = coordinates.longitude;
			GeoCoordsWithAccuracyBase geoCoordsWithAccuracyBase = geoCoordsWithAccuracy;
			double? horizontalAccuracy = coordinates.horizontalAccuracy;
			float horizontalAccuracy2;
			if (horizontalAccuracy == null)
			{
				horizontalAccuracy2 = -1f;
			}
			else
			{
				double? horizontalAccuracy3 = coordinates.horizontalAccuracy;
				horizontalAccuracy2 = (float)horizontalAccuracy3.Value;
			}
			geoCoordsWithAccuracyBase.horizontalAccuracy = horizontalAccuracy2;
			return geoCoordsWithAccuracy;
		}

		public static readonly GeoCoordsWithAccuracy UNKNOWN = new GeoCoordsWithAccuracy
		{
			latitude = 0.0,
			longitude = 0.0,
			horizontalAccuracy = -1f
		};
	}
}
