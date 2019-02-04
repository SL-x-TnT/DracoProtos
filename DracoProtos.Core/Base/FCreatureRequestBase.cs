using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FCreatureRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.id = stream.ReadUtfString();
			this.veryFirst = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteUtfString(this.id);
			stream.WriteBoolean(this.veryFirst);
		}

		public string id;

		public bool veryFirst;
	}
}
