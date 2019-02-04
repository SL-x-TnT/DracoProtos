using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FDungeonUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.rotation = stream.ReadFloat();
			this.size = stream.ReadInt32();
			this.type = (DungeonShapeType)stream.ReadEnum(typeof(DungeonShapeType));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticObject(this.coords);
			stream.WriteFloat(this.rotation);
			stream.WriteInt32(this.size);
			stream.WriteEnum(this.type);
		}

		public GeoCoords coords;

		public DungeonShapeType type;

		public float rotation;

		public int size;
	}
}
