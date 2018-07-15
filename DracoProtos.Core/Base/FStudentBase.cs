using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FStudentBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.allianceType = (AllianceType?)stream.ReadDynamicObject();
			this.level = stream.ReadInt32();
			this.nickname = stream.ReadUtfString();
			this.userId = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.allianceType);
			stream.WriteInt32(this.level);
			stream.WriteUtfString(this.nickname);
			stream.WriteUtfString(this.userId);
		}

		public string userId;

		public string nickname;

		public int level;

		public AllianceType? allianceType;
	}
}
