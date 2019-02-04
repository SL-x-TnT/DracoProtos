using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
    public class FLootItemInstantUseItem : FLootItemInstantUseItemBase
	{
		public override void SetSprite(RawImage rawImage)
		{
		}

		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.item;
		}
	}
}
