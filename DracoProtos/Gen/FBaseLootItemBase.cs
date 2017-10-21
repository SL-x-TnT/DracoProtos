using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBaseLootItemBase : FObject
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
