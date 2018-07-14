using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FFightRequestBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.battleId = (string)stream.ReadDynamicObject();
			this.chargedAttacksByAi = stream.ReadInt32();
			this.dodges = stream.ReadInt32();
			this.items = stream.ReadStaticList<FFightItem>(true);
			this.leaveBattle = stream.ReadBoolean();
			this.successfulDodges = stream.ReadInt32();
			this.timeout = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.battleId);
			stream.WriteInt32(this.chargedAttacksByAi);
			stream.WriteInt32(this.dodges);
			stream.WriteStaticCollection(this.items, true);
			stream.WriteBoolean(this.leaveBattle);
			stream.WriteInt32(this.successfulDodges);
			stream.WriteBoolean(this.timeout);
		}

		public string battleId;

		public List<FFightItem> items;

		public bool leaveBattle;

		public int chargedAttacksByAi;

		public int dodges;

		public int successfulDodges;

		public bool timeout;
	}
}
