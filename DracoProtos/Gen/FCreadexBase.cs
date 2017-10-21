using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FCreadexBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.entries = stream.ReadStaticList<FCreadexEntry>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.entries, true);
		}

		public List<FCreadexEntry> entries;
	}
}
