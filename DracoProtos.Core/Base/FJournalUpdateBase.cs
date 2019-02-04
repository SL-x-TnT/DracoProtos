using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FJournalUpdateBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.records = stream.ReadStaticList<FJournalRecord>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.records, true);
		}

		public List<FJournalRecord> records;
	}
}
