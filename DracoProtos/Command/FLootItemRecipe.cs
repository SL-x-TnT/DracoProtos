namespace DracoProtos.Command
{
    public class FLootItemRecipe : FLootItemRecipeBase
	{

		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.recipe;
		}
	}
}
