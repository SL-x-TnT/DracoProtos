using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FQuestCompletedBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.dailyQuest = (FDailyQuest)stream.ReadDynamicObject();
			this.levelUpLoot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.weeklyQuest = stream.ReadBoolean();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.dailyQuest);
			stream.WriteStaticObject(this.levelUpLoot);
			stream.WriteStaticObject(this.loot);
			stream.WriteBoolean(this.weeklyQuest);
		}

		public FDailyQuest dailyQuest;

		public bool weeklyQuest;

		public FLoot loot;

		public FLoot levelUpLoot;
	}
}
