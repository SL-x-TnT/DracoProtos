using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FLootItemRecipeBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.level = stream.ReadInt32();
			this.recipe = (RecipeType)stream.ReadEnum(typeof(RecipeType));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteInt32(this.level);
			stream.WriteEnum(this.recipe);
		}

		public RecipeType recipe;

		public int level;
	}
}
