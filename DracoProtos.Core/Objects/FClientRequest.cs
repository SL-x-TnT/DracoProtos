using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FClientRequest : FClientRequestBase
	{
		public FClientRequest()
		{
#pragma warning disable CS0618 // Le type ou le membre est obsolète
            this.currentUtcOffsetSeconds = (int)TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalSeconds;
#pragma warning restore CS0618 // Le type ou le membre est obsolète
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
