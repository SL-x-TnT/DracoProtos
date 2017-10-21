using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
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
