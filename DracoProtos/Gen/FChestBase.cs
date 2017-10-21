using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FChestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.id = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.coords);
			stream.WriteUtfString(this.id);
		}

		public string id;

		public GeoCoords coords;
	}
}
