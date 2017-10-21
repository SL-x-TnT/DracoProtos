using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FCreadexEntryBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.caughtQuantity = stream.ReadInt32();
			this.chain = stream.ReadDynamicList<FCreadexChain>(true);
			this.element = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.name = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.seen = stream.ReadBoolean();
			this.tier = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.caughtQuantity);
			stream.WriteDynamicCollection(this.chain, true);
			stream.WriteEnum(this.element);
			stream.WriteEnum(this.name);
			stream.WriteBoolean(this.seen);
			stream.WriteInt32(this.tier);
		}

		public ElementType element;

		public CreatureType name;

		public bool seen;

		public int tier;

		public int caughtQuantity;

		public List<FCreadexChain> chain;
	}
}
