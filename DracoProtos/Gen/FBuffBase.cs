using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBuffBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.buffType = (BuffType)stream.ReadEnum(typeof(BuffType));
			this.duration = stream.ReadInt64();
			this.timeLeft = stream.ReadInt64();
			this.valuePercent = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteEnum(this.buffType);
			stream.WriteInt64(this.duration);
			stream.WriteInt64(this.timeLeft);
			stream.WriteInt32(this.valuePercent);
		}

		public BuffType buffType;

		public int valuePercent;

		public long timeLeft;

		public long duration;
	}
}
