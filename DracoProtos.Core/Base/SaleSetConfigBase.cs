using System;
using System.Collections.Generic;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class SaleSetConfigBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.items = stream.ReadStaticMap<ItemType, int>(true, true);
			this.price = stream.ReadInt32();
			this.type = (SaleSetType)stream.ReadEnum(typeof(SaleSetType));
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticMap(this.items, true, true);
			stream.WriteInt32(this.price);
			stream.WriteEnum(this.type);
		}

		public SaleSetType type;

		public int price;

		public Dictionary<ItemType, int> items;
	}
}
