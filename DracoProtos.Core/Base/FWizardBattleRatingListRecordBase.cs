using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FWizardBattleRatingListRecordBase : FBaseRatingRecord
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.battleCount = stream.ReadInt32();
			this.savedHealthRate = stream.ReadFloat();
			this.winCount = stream.ReadInt32();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteInt32(this.battleCount);
			stream.WriteFloat(this.savedHealthRate);
			stream.WriteInt32(this.winCount);
		}

		public int battleCount;

		public int winCount;

		public float savedHealthRate;
	}
}
