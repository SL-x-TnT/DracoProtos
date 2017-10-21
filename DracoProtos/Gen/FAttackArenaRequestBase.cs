using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FAttackArenaRequestBase : FObject
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
