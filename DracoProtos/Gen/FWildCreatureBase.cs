using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FWildCreatureBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.coords = (GeoCoords)stream.ReadDynamicObject();
			this.entry = (FCreadexEntry)stream.ReadDynamicObject();
			this.id = stream.ReadUtfString();
			this.incenseUserId = (string)stream.ReadDynamicObject();
			this.isFirstCreature = stream.ReadBoolean();
			this.name = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.relatedBuildingId = (string)stream.ReadDynamicObject();
			this.scaleCollider = stream.ReadFloat();
			this.ttl = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.coords);
			stream.WriteDynamicObject(this.entry);
			stream.WriteUtfString(this.id);
			stream.WriteDynamicObject(this.incenseUserId);
			stream.WriteBoolean(this.isFirstCreature);
			stream.WriteEnum(this.name);
			stream.WriteDynamicObject(this.relatedBuildingId);
			stream.WriteFloat(this.scaleCollider);
			stream.WriteFloat(this.ttl);
		}

		public string id;

		public string relatedBuildingId;

		public string incenseUserId;

		public GeoCoords coords;

		public CreatureType name;

		public FCreadexEntry entry;

		public bool isFirstCreature;

		public float ttl;

		public float scaleCollider;
	}
}
