using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FEncounterDetailsBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.creatureCp = stream.ReadInt32();
			this.creatureElementType = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.creatureName = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.id = stream.ReadUtfString();
			this.level = stream.ReadInt32();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticObject(this.coords);
			stream.WriteInt32(this.creatureCp);
			stream.WriteEnum(this.creatureElementType);
			stream.WriteEnum(this.creatureName);
			stream.WriteUtfString(this.id);
			stream.WriteInt32(this.level);
		}

		public string id;

		public GeoCoords coords;

		public CreatureType creatureName;

		public ElementType creatureElementType;

		public int level;

		public int creatureCp;
	}
}
