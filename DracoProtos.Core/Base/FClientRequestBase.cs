﻿using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FClientRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.coordsWithAccuracy = (GeoCoordsWithAccuracy)stream.ReadStaticObject(typeof(GeoCoordsWithAccuracy));
			this.currentUtcOffsetSeconds = stream.ReadInt32();
			this.time = stream.ReadInt64();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.coordsWithAccuracy);
			stream.WriteInt32(this.currentUtcOffsetSeconds);
			stream.WriteInt64(this.time);
		}

		public long time;

		public int currentUtcOffsetSeconds;

		public GeoCoordsWithAccuracy coordsWithAccuracy;
	}
}
