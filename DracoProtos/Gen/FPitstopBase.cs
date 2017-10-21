using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FPitstopBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.cooldown = stream.ReadBoolean();
			this.lureBy = (string)stream.ReadDynamicObject();
			this.lureTimeLeft = stream.ReadInt64();
			this.personalized = (PersonalizedStop?)stream.ReadDynamicObject();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.cooldown);
			stream.WriteDynamicObject(this.lureBy);
			stream.WriteInt64(this.lureTimeLeft);
			stream.WriteDynamicObject(this.personalized);
		}

		public PersonalizedStop? personalized;

		public long lureTimeLeft;

		public string lureBy;

		public bool cooldown;
	}
}
