namespace DracoProtos.Command
{
    public class FLootItemDust : FLootItemDustBase
	{

		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.isStreak;
		}
	}
}
