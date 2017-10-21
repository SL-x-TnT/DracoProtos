using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBagItemBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.count = stream.ReadInt32();
			this.removable = stream.ReadBoolean();
			this.stack = stream.ReadBoolean();
			this.type = (ItemType)stream.ReadEnum(typeof(ItemType));
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.count);
			stream.WriteBoolean(this.removable);
			stream.WriteBoolean(this.stack);
			stream.WriteEnum(this.type);
		}

		public ItemType type;

		public int count;

		public bool removable;

		public bool stack;
	}
}
