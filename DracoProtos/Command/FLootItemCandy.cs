namespace DracoProtos.Command
{
    public class FLootItemCandy : FLootItemCandyBase
	{
		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.candyType;
		}
	}
}
