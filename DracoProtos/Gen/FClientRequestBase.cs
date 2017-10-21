using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FClientRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.currentUtcOffsetSeconds = stream.ReadInt32();
			this.time = stream.ReadInt64();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.coords);
			stream.WriteInt32(this.currentUtcOffsetSeconds);
			stream.WriteInt64(this.time);
		}

		public long time;

		public int currentUtcOffsetSeconds;

		public GeoCoords coords;
	}
}
