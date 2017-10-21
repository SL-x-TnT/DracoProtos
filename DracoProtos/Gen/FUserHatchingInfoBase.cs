using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FUserHatchingInfoBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.eggs = stream.ReadStaticList<FEgg>(true);
			this.incubators = stream.ReadStaticList<FIncubator>(true);
			this.max = stream.ReadInt32();
			this.maxRoost = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.eggs, true);
			stream.WriteStaticCollection(this.incubators, true);
			stream.WriteInt32(this.max);
			stream.WriteInt32(this.maxRoost);
		}

		public List<FEgg> eggs;

		public List<FIncubator> incubators;

		public int maxRoost;

		public int max;
	}
}
