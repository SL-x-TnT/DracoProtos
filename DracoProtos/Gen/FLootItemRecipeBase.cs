using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FLootItemRecipeBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.recipe = (RecipeType)stream.ReadEnum(typeof(RecipeType));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteEnum(this.recipe);
		}

		public RecipeType recipe;
	}
}
