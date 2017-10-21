using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FUserCreatureUpdateBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.avaUpdate = (FAvaUpdate)stream.ReadStaticObject(typeof(FAvaUpdate));
			this.creadex = (FCreadex)stream.ReadDynamicObject();
			this.creature = (FUserCreature)stream.ReadStaticObject(typeof(FUserCreature));
			this.levelUpLoot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.avaUpdate);
			stream.WriteDynamicObject(this.creadex);
			stream.WriteStaticObject(this.creature);
			stream.WriteStaticObject(this.levelUpLoot);
			stream.WriteStaticObject(this.loot);
		}

		public FUserCreature creature;

		public FAvaUpdate avaUpdate;

		public FLoot loot;

		public FLoot levelUpLoot;

		public FCreadex creadex;
	}
}
