using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FPickItemsResponseBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.levelUpLoot = (FLoot)stream.ReadDynamicObject();
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.levelUpLoot);
			stream.WriteStaticObject(this.loot);
		}

		public FLoot loot;

		public FLoot levelUpLoot;
	}
}
