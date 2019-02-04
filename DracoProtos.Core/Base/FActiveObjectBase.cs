using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FActiveObjectBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.allianceType = (AllianceType?)stream.ReadDynamicObject();
			this.arenaId = stream.ReadUtfString();
			this.combinedName = stream.ReadInt32();
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.creatureAlias = (string)stream.ReadDynamicObject();
			this.creatureCp = stream.ReadInt32();
			this.creatureName = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.level = stream.ReadInt32();
			this.lost = stream.ReadBoolean();
			this.timeLeft = stream.ReadFloat();
			this.weaklyBonus = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.allianceType);
			stream.WriteUtfString(this.arenaId);
			stream.WriteInt32(this.combinedName);
			stream.WriteStaticObject(this.coords);
			stream.WriteDynamicObject(this.creatureAlias);
			stream.WriteInt32(this.creatureCp);
			stream.WriteEnum(this.creatureName);
			stream.WriteInt32(this.level);
			stream.WriteBoolean(this.lost);
			stream.WriteFloat(this.timeLeft);
			stream.WriteInt32(this.weaklyBonus);
		}

		public int combinedName;

		public string arenaId;

		public CreatureType creatureName;

		public string creatureAlias;

		public int creatureCp;

		public int level;

		public AllianceType? allianceType;

		public float timeLeft;

		public bool lost;

		public GeoCoords coords;

		public int weaklyBonus;
	}
}
