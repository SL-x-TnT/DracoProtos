using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FAltarDetailsBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.buildingId = stream.ReadUtfString();
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.ownerId = stream.ReadUtfString();
			this.recipeName = (RecipeType)stream.ReadEnum(typeof(RecipeType));
			this.runeOwnerNames = stream.ReadStaticMap<int, string>(true, true);
			this.runeOwners = stream.ReadStaticMap<int, string>(true, true);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteUtfString(this.buildingId);
			stream.WriteStaticObject(this.coords);
			stream.WriteUtfString(this.ownerId);
			stream.WriteEnum(this.recipeName);
			stream.WriteStaticMap(this.runeOwnerNames, true, true);
			stream.WriteStaticMap(this.runeOwners, true, true);
		}

		public string buildingId;

		public string ownerId;

		public RecipeType recipeName;

		public Dictionary<int, string> runeOwners;

		public Dictionary<int, string> runeOwnerNames;

		public GeoCoords coords;
	}
}
