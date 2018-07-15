using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FClientLogRecord : FClientLogRecordBase
	{
		public FClientLogRecord()
		{
		}

		public FClientLogRecord(string clientStart, float realtimeSinceStartup, string log, string msg)
		{
			this.clientStartTime = clientStart;
			this.clientTime = realtimeSinceStartup;
			this.logName = log;
			this.message = msg;
		}
	}
}
