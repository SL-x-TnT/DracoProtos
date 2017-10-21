using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FLootItemItemBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.isStreak = stream.ReadBoolean();
			this.item = (ItemType)stream.ReadEnum(typeof(ItemType));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteBoolean(this.isStreak);
			stream.WriteEnum(this.item);
		}

		public ItemType item;

		public bool isStreak;
	}
}
