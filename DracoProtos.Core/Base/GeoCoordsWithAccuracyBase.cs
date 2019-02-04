using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class GeoCoordsWithAccuracyBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.horizontalAccuracy = stream.ReadFloat();
			this.latitude = stream.ReadDouble();
			this.longitude = stream.ReadDouble();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteFloat(this.horizontalAccuracy);
			stream.WriteDouble(this.latitude);
			stream.WriteDouble(this.longitude);
		}

		public double latitude;

		public double longitude;

		public float horizontalAccuracy;
	}
}
