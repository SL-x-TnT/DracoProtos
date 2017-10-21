using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FStartEncounterRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.attackerId = stream.ReadUtfString();
			this.defenderId = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteUtfString(this.attackerId);
			stream.WriteUtfString(this.defenderId);
		}

		public string defenderId;

		public string attackerId;
	}
}
