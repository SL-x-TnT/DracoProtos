using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FFeedMonsterResultBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.feedLiveTime = stream.ReadInt64();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt64(this.feedLiveTime);
		}

		public long feedLiveTime;
	}
}
