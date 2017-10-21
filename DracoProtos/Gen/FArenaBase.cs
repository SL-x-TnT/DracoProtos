using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FArenaBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.allianceType = (AllianceType?)stream.ReadDynamicObject();
			this.combinedName = stream.ReadInt32();
			this.protectionTtl = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.allianceType);
			stream.WriteInt32(this.combinedName);
			stream.WriteFloat(this.protectionTtl);
		}

		public AllianceType? allianceType;

		public int combinedName;

		public float protectionTtl;
	}
}
