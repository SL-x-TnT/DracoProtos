using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FCreadexChainBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.caught = stream.ReadBoolean();
			this.creature = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.seen = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.caught);
			stream.WriteEnum(this.creature);
			stream.WriteBoolean(this.seen);
		}

		public CreatureType creature;

		public bool seen;

		public bool caught;
	}
}
