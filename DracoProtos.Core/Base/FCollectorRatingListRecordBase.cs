using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FCollectorRatingListRecordBase : FBaseRatingRecord
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.openCreaturesCount = stream.ReadInt32();
			this.topQualityCreaturesCount = stream.ReadInt32();
			this.topQualityPoweredupCreaturesCount = stream.ReadInt32();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteInt32(this.openCreaturesCount);
			stream.WriteInt32(this.topQualityCreaturesCount);
			stream.WriteInt32(this.topQualityPoweredupCreaturesCount);
		}

		public int openCreaturesCount;

		public int topQualityCreaturesCount;

		public int topQualityPoweredupCreaturesCount;
	}
}
