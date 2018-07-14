using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FBaseLootItemBase : IFObject
	{
		public virtual void ReadExternal(FInputStream stream)
		{
			this.qty = stream.ReadInt32();
		}

		public virtual void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.qty);
		}

		public int qty;
	}
}
