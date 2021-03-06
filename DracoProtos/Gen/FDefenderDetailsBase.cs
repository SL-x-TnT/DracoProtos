using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FDefenderDetailsBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.allianceType = (AllianceType)stream.ReadEnum(typeof(AllianceType));
			this.creatureAlias = (string)stream.ReadDynamicObject();
			this.creatureCp = stream.ReadInt32();
			this.creatureName = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.elementType = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.ownerLevel = stream.ReadInt32();
			this.ownerName = stream.ReadUtfString();
			this.userAppearance = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteEnum(this.allianceType);
			stream.WriteDynamicObject(this.creatureAlias);
			stream.WriteInt32(this.creatureCp);
			stream.WriteEnum(this.creatureName);
			stream.WriteEnum(this.elementType);
			stream.WriteInt32(this.ownerLevel);
			stream.WriteUtfString(this.ownerName);
			stream.WriteInt32(this.userAppearance);
		}

		public CreatureType creatureName;

		public string creatureAlias;

		public int creatureCp;

		public string ownerName;

		public int ownerLevel;

		public ElementType elementType;

		public int userAppearance;

		public AllianceType allianceType;
	}
}
