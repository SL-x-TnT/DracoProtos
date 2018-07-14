using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FWizardBattleResultBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.attackerHps = stream.ReadStaticList<float>(true);
			this.attackerTypes = stream.ReadStaticList<CreatureType>(true);
			this.avaUpdate = (FAvaUpdate)stream.ReadStaticObject(typeof(FAvaUpdate));
			this.candies = stream.ReadStaticList<CreatureType>(true);
			this.levelUpLoot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.resultScreenDelay = stream.ReadFloat();
			this.rewardPercent = stream.ReadFloat();
			this.victory = stream.ReadBoolean();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticCollection(this.attackerHps, true);
			stream.WriteStaticCollection(this.attackerTypes, true);
			stream.WriteStaticObject(this.avaUpdate);
			stream.WriteStaticCollection(this.candies, true);
			stream.WriteStaticObject(this.levelUpLoot);
			stream.WriteStaticObject(this.loot);
			stream.WriteFloat(this.resultScreenDelay);
			stream.WriteFloat(this.rewardPercent);
			stream.WriteBoolean(this.victory);
		}

		public bool victory;

		public List<CreatureType> attackerTypes;

		public List<float> attackerHps;

		public FLoot loot;

		public FLoot levelUpLoot;

		public float rewardPercent;

		public FAvaUpdate avaUpdate;

		public float resultScreenDelay;

		public List<CreatureType> candies;
	}
}
