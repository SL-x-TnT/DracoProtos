using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class AuthDataBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
            this.authType = (AuthType)stream.ReadEnum(typeof(AuthType));
			this.profileId = stream.ReadUtfString();
			this.tokenId = (string)stream.ReadDynamicObject();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteEnum(this.authType);
			stream.WriteUtfString(this.profileId);
			stream.WriteDynamicObject(this.tokenId);
		}

		public AuthType authType;

		public string profileId;

		public string tokenId;
	}
}
