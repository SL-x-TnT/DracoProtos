using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class GeoCoordsBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.horizontalAccuracy = (double?)stream.ReadDynamicObject();
			this.latitude = stream.ReadDouble();
			this.longitude = stream.ReadDouble();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.horizontalAccuracy);
			stream.WriteDouble(this.latitude);
			stream.WriteDouble(this.longitude);
		}

		public double latitude;

		public double longitude;

		public double? horizontalAccuracy;
	}
}
