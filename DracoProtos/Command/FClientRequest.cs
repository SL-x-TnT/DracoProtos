using System;

namespace DracoProtos.Command
{
    public class FClientRequest : FClientRequestBase
	{
		public FClientRequest()
		{
			this.currentUtcOffsetSeconds = (int)TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalSeconds;
		}

		public static FClientRequest CurrentLocation()
		{
			return new FClientRequest
			{
				coords = GeoCoords.UNKNOWN
			};
		}

		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"FClientRequest{time=",
				this.time,
				", latitude=",
				this.coords.latitude,
				", longitude=",
				this.coords.longitude,
				", horizontalAccuracy=",
				this.coords.horizontalAccuracy,
				'}'
			});
		}
	}
}
