using System.Collections.Generic;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FRecipeConfigBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.duration = stream.ReadInt32();
			this.percent = stream.ReadInt32();
			this.runes = stream.ReadStaticList<ItemType>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.duration);
			stream.WriteInt32(this.percent);
			stream.WriteStaticCollection(this.runes, true);
		}

		public List<ItemType> runes;

		public int duration;

		public int percent;
	}
}
