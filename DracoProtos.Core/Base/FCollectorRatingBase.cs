using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FCollectorRatingBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.topRecords = stream.ReadStaticList<FCollectorRatingListRecord>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.topRecords, true);
		}

		public List<FCollectorRatingListRecord> topRecords;
	}
}
