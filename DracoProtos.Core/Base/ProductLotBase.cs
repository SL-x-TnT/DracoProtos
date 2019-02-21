using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class ProductLotBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.isOfferPrice = stream.ReadBoolean();
			this.price = stream.ReadInt32();
			this.qty = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.isOfferPrice);
			stream.WriteInt32(this.price);
			stream.WriteInt32(this.qty);
		}

		public int qty;

		public int price;

		public bool isOfferPrice;
	}
}
