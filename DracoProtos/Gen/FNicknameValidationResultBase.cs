using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FNicknameValidationResultBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.error = (FNicknameValidationError?)stream.ReadDynamicObject();
			this.suggestedNickname = (string)stream.ReadDynamicObject();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.error);
			stream.WriteDynamicObject(this.suggestedNickname);
		}

		public FNicknameValidationError? error;

		public string suggestedNickname;
	}
}
