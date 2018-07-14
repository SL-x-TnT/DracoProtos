using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class ExtraPackBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.isOfferPrice = stream.ReadBoolean();
			this.price = stream.ReadInt32();
			this.wizardBattles = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.isOfferPrice);
			stream.WriteInt32(this.price);
			stream.WriteInt32(this.wizardBattles);
		}

		public int wizardBattles;

		public int price;

		public bool isOfferPrice;
	}
}
