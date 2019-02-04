using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FResistModifyDetailsBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.matchingCreatures = stream.ReadInt32();
			this.resultResistMax = stream.ReadFloat();
			this.resultResistMin = stream.ReadFloat();
			this.tier = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.matchingCreatures);
			stream.WriteFloat(this.resultResistMax);
			stream.WriteFloat(this.resultResistMin);
			stream.WriteInt32(this.tier);
		}

		public float resultResistMin;

		public float resultResistMax;

		public int matchingCreatures;

		public int tier;
	}
}
