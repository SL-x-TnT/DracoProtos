using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FLootItemInstantUseItemBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.item = (InstantUseItem)stream.ReadEnum(typeof(InstantUseItem));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteEnum(this.item);
		}

		public InstantUseItem item;
	}
}
