﻿using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class GeoCoordsBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.latitude = stream.ReadDouble();
			this.longitude = stream.ReadDouble();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDouble(this.latitude);
			stream.WriteDouble(this.longitude);
		}

		public double latitude;

		public double longitude;
	}
}
