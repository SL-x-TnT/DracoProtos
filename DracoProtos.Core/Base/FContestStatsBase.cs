using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FContestStatsBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.completed = stream.ReadBoolean();
			this.hpPercentTotal = stream.ReadFloat();
			this.isMyself = stream.ReadBoolean();
			this.lostAsOpponentCount = stream.ReadInt32();
			this.lostCount = stream.ReadInt32();
			this.nickname = stream.ReadUtfString();
			this.winAsOpponentCount = stream.ReadInt32();
			this.winCount = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.completed);
			stream.WriteFloat(this.hpPercentTotal);
			stream.WriteBoolean(this.isMyself);
			stream.WriteInt32(this.lostAsOpponentCount);
			stream.WriteInt32(this.lostCount);
			stream.WriteUtfString(this.nickname);
			stream.WriteInt32(this.winAsOpponentCount);
			stream.WriteInt32(this.winCount);
		}

		public string nickname;

		public bool isMyself;

		public bool completed;

		public int winCount;

		public int winAsOpponentCount;

		public int lostCount;

		public int lostAsOpponentCount;

		public float hpPercentTotal;
	}
}
