using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FQuestCompletedBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.activeObjects = (FActiveObjectsUpdate)stream.ReadDynamicObject();
			this.dailyQuest = (FDailyQuest)stream.ReadDynamicObject();
			this.goldenEgg = (FHatchedEggs)stream.ReadDynamicObject();
			this.levelUpLoot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.weeklyQuest = stream.ReadBoolean();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.activeObjects);
			stream.WriteDynamicObject(this.dailyQuest);
			stream.WriteDynamicObject(this.goldenEgg);
			stream.WriteStaticObject(this.levelUpLoot);
			stream.WriteStaticObject(this.loot);
			stream.WriteBoolean(this.weeklyQuest);
		}

		public FDailyQuest dailyQuest;

		public bool weeklyQuest;

		public FLoot loot;

		public FLoot levelUpLoot;

		public FActiveObjectsUpdate activeObjects;

		public FHatchedEggs goldenEgg;
	}
}
