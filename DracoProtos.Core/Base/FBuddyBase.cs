using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FBuddyBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.alias = (string)stream.ReadDynamicObject();
			this.candyType = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.creature = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.currentWalkedF = stream.ReadFloat();
			this.distanceForCandies = stream.ReadInt32();
			this.id = stream.ReadUtfString();
			this.totalCandies = stream.ReadInt32();
			this.totalWalkedF = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.alias);
			stream.WriteEnum(this.candyType);
			stream.WriteEnum(this.creature);
			stream.WriteFloat(this.currentWalkedF);
			stream.WriteInt32(this.distanceForCandies);
			stream.WriteUtfString(this.id);
			stream.WriteInt32(this.totalCandies);
			stream.WriteFloat(this.totalWalkedF);
		}

		public string id;

		public CreatureType creature;

		public CreatureType candyType;

		public string alias;

		public float currentWalkedF;

		public int distanceForCandies;

		public float totalWalkedF;

		public int totalCandies;
	}
}
