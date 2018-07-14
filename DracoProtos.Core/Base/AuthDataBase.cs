﻿using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class AuthDataBase : IFObject
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
