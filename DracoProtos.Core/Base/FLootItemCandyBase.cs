using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FLootItemCandyBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.candyType = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.fromBuddy = stream.ReadBoolean();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteEnum(this.candyType);
			stream.WriteBoolean(this.fromBuddy);
		}

		public CreatureType candyType;

		public bool fromBuddy;
	}
}
