using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FLootItemDustBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.isStreak = stream.ReadBoolean();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteBoolean(this.isStreak);
		}

		public bool isStreak;
	}
}
