using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class ProductLotBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.price = stream.ReadInt32();
			this.qty = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.price);
			stream.WriteInt32(this.qty);
		}

		public int qty;

		public int price;
	}
}
