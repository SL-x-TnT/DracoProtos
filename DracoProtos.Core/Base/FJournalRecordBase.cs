using System.Collections.Generic;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FJournalRecordBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.date = stream.ReadInt64();
			this.details = stream.ReadStaticMap<string, string>(true, true);
			this.type = (EventLogType)stream.ReadEnum(typeof(EventLogType));
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt64(this.date);
			stream.WriteStaticMap(this.details, true, true);
			stream.WriteEnum(this.type);
		}

		public EventLogType type;

		public long date;

		public Dictionary<string, string> details;
	}
}
