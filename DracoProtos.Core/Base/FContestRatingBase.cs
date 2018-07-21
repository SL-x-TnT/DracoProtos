using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FContestRatingBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.topRecords = stream.ReadStaticList<FContestRatingListRecord>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.topRecords, true);
		}

		public List<FContestRatingListRecord> topRecords;
	}
}
