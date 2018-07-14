using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FResistModifyDetailsBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.matchingCreatures = stream.ReadInt32();
			this.resultResistMax = stream.ReadFloat();
			this.resultResistMin = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.matchingCreatures);
			stream.WriteFloat(this.resultResistMax);
			stream.WriteFloat(this.resultResistMin);
		}

		public float resultResistMin;

		public float resultResistMax;

		public int matchingCreatures;
	}
}
