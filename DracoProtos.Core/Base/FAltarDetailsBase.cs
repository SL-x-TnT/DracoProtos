using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FAltarDetailsBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.buildingId = stream.ReadUtfString();
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.ownerNickname = stream.ReadUtfString();
			this.recipeLevel = stream.ReadInt32();
			this.recipeName = (RecipeType)stream.ReadEnum(typeof(RecipeType));
			this.runeOwnerNames = stream.ReadStaticMap<int, string>(true, true);
			this.runeOwners = stream.ReadStaticMap<int, string>(true, true);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteUtfString(this.buildingId);
			stream.WriteStaticObject(this.coords);
			stream.WriteUtfString(this.ownerNickname);
			stream.WriteInt32(this.recipeLevel);
			stream.WriteEnum(this.recipeName);
			stream.WriteStaticMap(this.runeOwnerNames, true, true);
			stream.WriteStaticMap(this.runeOwners, true, true);
		}

		public string buildingId;

		public string ownerNickname;

		public RecipeType recipeName;

		public int recipeLevel;

		public Dictionary<int, string> runeOwners;

		public Dictionary<int, string> runeOwnerNames;

		public GeoCoords coords;
	}
}
