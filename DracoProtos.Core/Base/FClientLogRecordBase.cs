﻿using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FClientLogRecordBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.clientStartTime = stream.ReadUtfString();
			this.clientTime = stream.ReadFloat();
			this.logName = stream.ReadUtfString();
			this.message = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteUtfString(this.clientStartTime);
			stream.WriteFloat(this.clientTime);
			stream.WriteUtfString(this.logName);
			stream.WriteUtfString(this.message);
		}

		public string clientStartTime;

		public float clientTime;

		public string logName;

		public string message;
	}
}
