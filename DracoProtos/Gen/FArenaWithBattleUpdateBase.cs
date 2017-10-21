using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FArenaWithBattleUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.arenaWithBattle = stream.ReadStaticHashSet<string>(true);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticEnumerable(this.arenaWithBattle, true);
		}

		public HashSet<string> arenaWithBattle;
	}
}
