using System;
using System.Collections.Generic;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class PotionConfigBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.heals = stream.ReadStaticMap<ItemType, int>(true, true);
			this.resurrections = stream.ReadStaticMap<ItemType, float>(true, true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticMap(this.heals, true, true);
			stream.WriteStaticMap(this.resurrections, true, true);
		}

		public Dictionary<ItemType, int> heals;

		public Dictionary<ItemType, float> resurrections;
	}
}
