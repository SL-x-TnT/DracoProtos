using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FWizardBattleResultBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.attackerHps = stream.ReadStaticList<float>(true);
			this.attackerTypes = stream.ReadStaticList<CreatureType>(true);
			this.creaturesDefeated = stream.ReadInt32();
			this.levelUpLoot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.resultScreenDelay = stream.ReadFloat();
			this.victory = stream.ReadBoolean();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticCollection(this.attackerHps, true);
			stream.WriteStaticCollection(this.attackerTypes, true);
			stream.WriteInt32(this.creaturesDefeated);
			stream.WriteStaticObject(this.levelUpLoot);
			stream.WriteStaticObject(this.loot);
			stream.WriteFloat(this.resultScreenDelay);
			stream.WriteBoolean(this.victory);
		}

		public bool victory;

		public int creaturesDefeated;

		public List<CreatureType> attackerTypes;

		public List<float> attackerHps;

		public FLoot loot;

		public FLoot levelUpLoot;

		public float resultScreenDelay;
	}
}
