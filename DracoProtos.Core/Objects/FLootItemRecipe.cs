using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FLootItemRecipe : FLootItemRecipeBase
	{
		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.recipe;
		}

        public override void SetSprite(RawImage rawImage)
        {
            //throw new NotImplementedException();
        }
    }

    public class RawImage
    {
    }
}
