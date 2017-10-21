using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FDepositInfoBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.depositAmount = stream.ReadInt32();
			this.duration = stream.ReadInt32();
			this.isOnUser = stream.ReadBoolean();
			this.leftTime = stream.ReadInt64();
			this.percent = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.depositAmount);
			stream.WriteInt32(this.duration);
			stream.WriteBoolean(this.isOnUser);
			stream.WriteInt64(this.leftTime);
			stream.WriteFloat(this.percent);
		}

		public float percent;

		public int duration;

		public bool isOnUser;

		public int depositAmount;

		public long leftTime;
	}
}
