using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBuildingBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.altar = (FAltar)stream.ReadDynamicObject();
			this.arena = (FArena)stream.ReadDynamicObject();
			this.available = stream.ReadBoolean();
			this.casted = stream.ReadBoolean();
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.dungeonId = (string)stream.ReadDynamicObject();
			this.expirationTime = stream.ReadInt64();
			this.id = stream.ReadUtfString();
			this.pitstop = (FPitstop)stream.ReadDynamicObject();
			this.type = (BuildingType)stream.ReadEnum(typeof(BuildingType));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.altar);
			stream.WriteDynamicObject(this.arena);
			stream.WriteBoolean(this.available);
			stream.WriteBoolean(this.casted);
			stream.WriteStaticObject(this.coords);
			stream.WriteDynamicObject(this.dungeonId);
			stream.WriteInt64(this.expirationTime);
			stream.WriteUtfString(this.id);
			stream.WriteDynamicObject(this.pitstop);
			stream.WriteEnum(this.type);
		}

		public string id;

		public GeoCoords coords;

		public BuildingType type;

		public bool available;

		public bool casted;

		public long expirationTime;

		public string dungeonId;

		public FPitstop pitstop;

		public FArena arena;

		public FAltar altar;
	}
}
