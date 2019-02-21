using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class IdAndCoordsBase : FObject
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
