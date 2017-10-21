using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FFightRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.chargedAttacksByAi = stream.ReadInt32();
			this.dodges = stream.ReadInt32();
			this.items = stream.ReadStaticList<FFightItem>(true);
			this.leaveBattle = stream.ReadBoolean();
			this.successfulDodges = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.chargedAttacksByAi);
			stream.WriteInt32(this.dodges);
			stream.WriteStaticCollection(this.items, true);
			stream.WriteBoolean(this.leaveBattle);
			stream.WriteInt32(this.successfulDodges);
		}

		public List<FFightItem> items;

		public bool leaveBattle;

		public int chargedAttacksByAi;

		public int dodges;

		public int successfulDodges;
	}
}
