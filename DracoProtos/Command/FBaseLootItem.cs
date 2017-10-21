namespace DracoProtos.Command
{
    public abstract class FBaseLootItem : FBaseLootItemBase
	{

		public virtual string GetLootGroup()
		{
			return base.GetType().FullName;
		}
	}
}
