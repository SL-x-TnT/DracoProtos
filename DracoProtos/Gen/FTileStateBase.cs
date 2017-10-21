using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FTileStateBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.buildings = stream.ReadStaticList<FBuilding>(true);
			this.time = stream.ReadInt64();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.buildings, true);
			stream.WriteInt64(this.time);
		}

		public long time;

		public List<FBuilding> buildings;
	}
}
