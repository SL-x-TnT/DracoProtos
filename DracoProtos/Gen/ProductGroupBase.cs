using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class ProductGroupBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.itemType = (ItemType)stream.ReadEnum(typeof(ItemType));
			this.productLots = stream.ReadStaticList<ProductLot>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteEnum(this.itemType);
			stream.WriteStaticCollection(this.productLots, true);
		}

		public ItemType itemType;

		public List<ProductLot> productLots;
	}
}
