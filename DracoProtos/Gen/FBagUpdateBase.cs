using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBagUpdateBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.allowedItemsSize = stream.ReadInt32();
			this.incenseGenMonstersGroupName = stream.ReadUtfString();
			this.items = stream.ReadStaticList<FBagItem>(true);
			this.lockedRunes = stream.ReadStaticMap<ItemType, int>(true, true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.allowedItemsSize);
			stream.WriteUtfString(this.incenseGenMonstersGroupName);
			stream.WriteStaticCollection(this.items, true);
			stream.WriteStaticMap(this.lockedRunes, true, true);
		}

		public string incenseGenMonstersGroupName;

		public int allowedItemsSize;

		public List<FBagItem> items;

		public Dictionary<ItemType, int> lockedRunes;
	}
}
