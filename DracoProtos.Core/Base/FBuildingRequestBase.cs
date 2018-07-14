using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FBuildingRequestBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.dungeonId = (string)stream.ReadDynamicObject();
			this.id = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.coords);
			stream.WriteDynamicObject(this.dungeonId);
			stream.WriteUtfString(this.id);
		}

		public string id;

		public GeoCoords coords;

		public string dungeonId;
	}
}
