using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FClientRequest : FClientRequestBase
	{
		public FClientRequest()
		{
            this.currentUtcOffsetSeconds = (int)TimeZoneInfo.Utc.GetUtcOffset(DateTime.Now).TotalSeconds;
        }

		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"FClientRequest{time=",
				this.time,
				", latitude=",
				this.coordsWithAccuracy.latitude,
				", longitude=",
				this.coordsWithAccuracy.longitude,
				", horizontalAccuracy=",
				this.coordsWithAccuracy.horizontalAccuracy,
				'}'
			});
		}
	}
}
