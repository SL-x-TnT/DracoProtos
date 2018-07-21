﻿using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class AuthData : AuthDataBase
	{
		public bool IsDevice()
		{
			return this.authType == AuthType.DEVICE;
		}

		public bool IsSocial()
		{
			return this.authType == AuthType.FACEBOOK || this.authType == AuthType.GOOGLE;
		}

		public override string ToString()
		{
			return string.Format("AuthType: {0}, ProfileId: {1}, TokenId: {2}", this.authType, this.profileId, this.tokenId);
		}
	}
}
