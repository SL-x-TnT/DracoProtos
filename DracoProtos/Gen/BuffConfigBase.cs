using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class BuffConfigBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.durationMs = stream.ReadInt64();
			this.type = (BuffType)stream.ReadEnum(typeof(BuffType));
			this.valuePercent = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt64(this.durationMs);
			stream.WriteEnum(this.type);
			stream.WriteInt32(this.valuePercent);
		}

		public BuffType type;

		public long durationMs;

		public int valuePercent;
	}
}
