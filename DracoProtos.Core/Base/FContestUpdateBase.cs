using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FContestUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.battles = stream.ReadStaticList<FContestBattle>(true);
			this.canStart = stream.ReadBoolean();
			this.contestId = stream.ReadUtfString();
			this.hideContestScreen = stream.ReadBoolean();
			this.isOwner = stream.ReadBoolean();
			this.ownerNickname = stream.ReadUtfString();
			this.participantList = stream.ReadStaticList<FContestParticipant>(true);
			this.participantTtl = stream.ReadFloat();
			this.pendingBattle = (string)stream.ReadDynamicObject();
			this.showContestScreen = stream.ReadBoolean();
			this.stage = (ContestStage)stream.ReadEnum(typeof(ContestStage));
			this.stats = stream.ReadStaticList<FContestStats>(true);
			this.totalBattlesCount = stream.ReadInt32();
			this.userBattlesCount = stream.ReadInt32();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticCollection(this.battles, true);
			stream.WriteBoolean(this.canStart);
			stream.WriteUtfString(this.contestId);
			stream.WriteBoolean(this.hideContestScreen);
			stream.WriteBoolean(this.isOwner);
			stream.WriteUtfString(this.ownerNickname);
			stream.WriteStaticCollection(this.participantList, true);
			stream.WriteFloat(this.participantTtl);
			stream.WriteDynamicObject(this.pendingBattle);
			stream.WriteBoolean(this.showContestScreen);
			stream.WriteEnum(this.stage);
			stream.WriteStaticCollection(this.stats, true);
			stream.WriteInt32(this.totalBattlesCount);
			stream.WriteInt32(this.userBattlesCount);
		}

		public string contestId;

		public bool showContestScreen;

		public bool hideContestScreen;

		public ContestStage stage;

		public bool isOwner;

		public string ownerNickname;

		public bool canStart;

		public List<FContestParticipant> participantList;

		public int userBattlesCount;

		public int totalBattlesCount;

		public List<FContestBattle> battles;

		public string pendingBattle;

		public List<FContestStats> stats;

		public float participantTtl;
	}
}
