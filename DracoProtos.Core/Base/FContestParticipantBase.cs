using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FContestParticipantBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.buffLevel = (int?)stream.ReadDynamicObject();
			this.isMaxLevel = stream.ReadBoolean();
			this.isMyself = stream.ReadBoolean();
			this.level = stream.ReadInt32();
			this.nickname = stream.ReadUtfString();
			this.startAccepted = (bool?)stream.ReadDynamicObject();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.buffLevel);
			stream.WriteBoolean(this.isMaxLevel);
			stream.WriteBoolean(this.isMyself);
			stream.WriteInt32(this.level);
			stream.WriteUtfString(this.nickname);
			stream.WriteDynamicObject(this.startAccepted);
		}

		public string nickname;

		public int level;

		public int? buffLevel;

		public bool isMaxLevel;

		public bool isMyself;

		public bool? startAccepted;
	}
}
