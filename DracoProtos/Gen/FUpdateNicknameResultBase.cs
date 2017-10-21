using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FUpdateNicknameResultBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.userInfo = (FUserInfo)stream.ReadDynamicObject();
			this.validationResult = (FNicknameValidationResult)stream.ReadDynamicObject();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.userInfo);
			stream.WriteDynamicObject(this.validationResult);
		}

		public FNicknameValidationResult validationResult;

		public FUserInfo userInfo;
	}
}
