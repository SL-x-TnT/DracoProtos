using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FActiveObjectsUpdateBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.arenaQuantity = stream.ReadInt32();
			this.coins = stream.ReadInt32();
			this.dust = stream.ReadInt32();
			this.increasedTribute = stream.ReadBoolean();
			this.libraryAvailableCharges = stream.ReadInt32();
			this.libraryPoints = stream.ReadInt32();
			this.libraryQuantity = stream.ReadInt32();
			this.libraryRequired = stream.ReadInt32();
			this.libraryTotalCharges = stream.ReadInt32();
			this.libraryTotalCooldown = stream.ReadFloat();
			this.libraryWaitCooldown = stream.ReadInt32();
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.maxArenas = stream.ReadInt32();
			this.objectList = stream.ReadStaticList<FActiveObject>(true);
			this.timeToNextTributeCollection = stream.ReadFloat();
			this.totalArenas = stream.ReadInt32();
			this.tributeCooldown = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.arenaQuantity);
			stream.WriteInt32(this.coins);
			stream.WriteInt32(this.dust);
			stream.WriteBoolean(this.increasedTribute);
			stream.WriteInt32(this.libraryAvailableCharges);
			stream.WriteInt32(this.libraryPoints);
			stream.WriteInt32(this.libraryQuantity);
			stream.WriteInt32(this.libraryRequired);
			stream.WriteInt32(this.libraryTotalCharges);
			stream.WriteFloat(this.libraryTotalCooldown);
			stream.WriteInt32(this.libraryWaitCooldown);
			stream.WriteStaticObject(this.loot);
			stream.WriteInt32(this.maxArenas);
			stream.WriteStaticCollection(this.objectList, true);
			stream.WriteFloat(this.timeToNextTributeCollection);
			stream.WriteInt32(this.totalArenas);
			stream.WriteFloat(this.tributeCooldown);
		}

		public float timeToNextTributeCollection;

		public float tributeCooldown;

		public int dust;

		public int coins;

		public bool increasedTribute;

		public int arenaQuantity;

		public int totalArenas;

		public int maxArenas;

		public int libraryQuantity;

		public int libraryPoints;

		public int libraryRequired;

		public int libraryWaitCooldown;

		public float libraryTotalCooldown;

		public int libraryAvailableCharges;

		public int libraryTotalCharges;

		public List<FActiveObject> objectList;

		public FLoot loot;
	}
}
