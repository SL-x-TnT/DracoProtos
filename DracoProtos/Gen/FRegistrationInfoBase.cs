using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FRegistrationInfoBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.age = stream.ReadUtfString();
			this.email = stream.ReadUtfString();
			this.gender = stream.ReadUtfString();
			this.regType = stream.ReadUtfString();
			this.socialId = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteUtfString(this.age);
			stream.WriteUtfString(this.email);
			stream.WriteUtfString(this.gender);
			stream.WriteUtfString(this.regType);
			stream.WriteUtfString(this.socialId);
		}

		public string email;

		public string regType;

		public string socialId;

		public string gender;

		public string age;
	}
}
