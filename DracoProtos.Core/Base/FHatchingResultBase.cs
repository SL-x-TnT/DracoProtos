using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FHatchingResultBase : FObject
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

		public FLoot loot;

		public FLoot levelUpLoot;

		public FCreadex creadex;

		public FAvaUpdate avaUpdate;
	}
}
