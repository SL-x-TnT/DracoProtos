using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FEncounterBattleResultBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.resultScreenDelay = stream.ReadFloat();
			this.victory = stream.ReadBoolean();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticObject(this.loot);
			stream.WriteFloat(this.resultScreenDelay);
			stream.WriteBoolean(this.victory);
		}

		public bool victory;

		public FLoot loot;

		public float resultScreenDelay;
	}
}
