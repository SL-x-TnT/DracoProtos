using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBuddyBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.alias = (string)stream.ReadDynamicObject();
			this.candyType = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.creature = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.currentWalked = stream.ReadInt32();
			this.distanceForCandies = stream.ReadInt32();
			this.id = stream.ReadUtfString();
			this.totalCandies = stream.ReadInt32();
			this.totalWalked = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.alias);
			stream.WriteEnum(this.candyType);
			stream.WriteEnum(this.creature);
			stream.WriteInt32(this.currentWalked);
			stream.WriteInt32(this.distanceForCandies);
			stream.WriteUtfString(this.id);
			stream.WriteInt32(this.totalCandies);
			stream.WriteInt32(this.totalWalked);
		}

		public string id;

		public CreatureType creature;

		public CreatureType candyType;

		public string alias;

		public int currentWalked;

		public int distanceForCandies;

		public int totalWalked;

		public int totalCandies;
	}
}
