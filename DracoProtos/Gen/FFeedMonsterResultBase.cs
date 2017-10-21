using System;
using DracoProtos.Serializer;

namespace DracoProtos
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
