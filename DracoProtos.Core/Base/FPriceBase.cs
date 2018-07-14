using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FPriceBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.isOffer = stream.ReadBoolean();
			this.price = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.isOffer);
			stream.WriteInt32(this.price);
		}

		public int price;

		public bool isOffer;
	}
}
