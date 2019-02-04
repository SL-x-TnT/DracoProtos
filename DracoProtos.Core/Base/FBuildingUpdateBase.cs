using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
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
