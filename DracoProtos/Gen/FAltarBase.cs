using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FAltarBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.ownerId = stream.ReadUtfString();
			this.sharedWithEmptyPassword = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteUtfString(this.ownerId);
			stream.WriteBoolean(this.sharedWithEmptyPassword);
		}

		public string ownerId;

		public bool sharedWithEmptyPassword;
	}
}
