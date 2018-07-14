using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FAttackArenaRequestBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.buildingRequest = (FBuildingRequest)stream.ReadStaticObject(typeof(FBuildingRequest));
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.selectedCreatures = stream.ReadStaticList<string>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.buildingRequest);
			stream.WriteStaticObject(this.coords);
			stream.WriteStaticCollection(this.selectedCreatures, true);
		}

		public FBuildingRequest buildingRequest;

		public List<string> selectedCreatures;

		public GeoCoords coords;
	}
}
