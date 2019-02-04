using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FContestRatingListRecordBase : FBaseRatingRecord
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.awardDust = stream.ReadInt32();
			this.awardRunes = stream.ReadInt32();
			this.contestCount = stream.ReadInt32();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteInt32(this.awardDust);
			stream.WriteInt32(this.awardRunes);
			stream.WriteInt32(this.contestCount);
		}

		public int contestCount;

		public int awardRunes;

		public int awardDust;
	}
}
