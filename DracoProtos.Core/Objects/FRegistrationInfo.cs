using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FRegistrationInfo : FRegistrationInfoBase
	{
		public FRegistrationInfo()
		{
		}

		public FRegistrationInfo(string regType)
		{
			this.email = string.Empty;
			this.regType = regType;
			this.socialId = string.Empty;
			this.gender = string.Empty;
			this.age = string.Empty;
		}
	}
}
