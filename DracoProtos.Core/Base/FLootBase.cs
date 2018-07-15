using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FLootBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.lootList = stream.ReadStaticList<FBaseLootItem>(false);
			this.streakIndex = (int?)stream.ReadDynamicObject();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticCollection(this.lootList, false);
			stream.WriteDynamicObject(this.streakIndex);
		}

		public int? streakIndex;

		public List<FBaseLootItem> lootList;
	}
}
