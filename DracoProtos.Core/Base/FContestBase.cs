using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FContestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.emptyPassword = stream.ReadBoolean();
			this.ownerId = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.emptyPassword);
			stream.WriteUtfString(this.ownerId);
		}

		public string ownerId;

		public bool emptyPassword;
	}
}
