using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FWeeklyQuestFragmentBase : IFObject
	{
        public sbyte data;
        public int fragmentNumber;

        public void ReadExternal(FInputStream stream)
		{
			this.data = stream.ReadSByte();
			this.fragmentNumber = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteSByte(this.data);
			stream.WriteInt32(this.fragmentNumber);
		}
	}
}
