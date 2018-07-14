using System.Collections.Generic;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FItemCreatureGroupBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.active = stream.ReadBoolean();
			this.creature = (CreatureType?)stream.ReadDynamicObject();
			this.isOfferPrice = stream.ReadBoolean();
			this.items = stream.ReadDynamicMap<ItemType, int>(true, true);
			this.price = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.active);
			stream.WriteDynamicObject(this.creature);
			stream.WriteBoolean(this.isOfferPrice);
			stream.WriteDynamicMap(this.items, true, true);
			stream.WriteInt32(this.price);
		}

		public CreatureType? creature;

		public Dictionary<ItemType, int> items;

		public int price;

		public bool isOfferPrice;

		public bool active;
	}
}
