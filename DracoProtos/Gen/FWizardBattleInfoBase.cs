using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FWizardBattleInfoBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.enhanced = stream.ReadBoolean();
			this.limit = stream.ReadInt32();
			this.timeToRefresh = stream.ReadFloat();
			this.used = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.enhanced);
			stream.WriteInt32(this.limit);
			stream.WriteFloat(this.timeToRefresh);
			stream.WriteInt32(this.used);
		}

		public bool enhanced;

		public int limit;

		public int used;

		public float timeToRefresh;
	}
}
