using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FWeeklyQuestFragmentBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.data = stream.ReadStaticArray<sbyte>(true);
			this.fragmentNumber = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.data, true);
			stream.WriteInt32(this.fragmentNumber);
		}

		public int fragmentNumber;

		public sbyte[] data;
	}
}
