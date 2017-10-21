namespace DracoProtos.Command
{
    public class FLootItemInstantUseItem : FLootItemInstantUseItemBase
	{
		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.item;
		}
	}
}
