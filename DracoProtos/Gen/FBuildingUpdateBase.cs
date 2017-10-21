using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBuildingUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.tileBuildings = stream.ReadStaticMap<FTile, FTileState>(true, true);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticMap(this.tileBuildings, true, true);
		}

		public Dictionary<FTile, FTileState> tileBuildings;
	}
}
