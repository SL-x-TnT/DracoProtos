using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FContestBattleBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.hpPercent = stream.ReadFloat();
			this.isMyBattle = stream.ReadBoolean();
			this.nickname = stream.ReadUtfString();
			this.nicknameOpponent = stream.ReadUtfString();
			this.timeout = stream.ReadBoolean();
			this.victory = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteFloat(this.hpPercent);
			stream.WriteBoolean(this.isMyBattle);
			stream.WriteUtfString(this.nickname);
			stream.WriteUtfString(this.nicknameOpponent);
			stream.WriteBoolean(this.timeout);
			stream.WriteBoolean(this.victory);
		}

		public string nickname;

		public string nicknameOpponent;

		public bool isMyBattle;

		public bool victory;

		public bool timeout;

		public float hpPercent;
	}
}
