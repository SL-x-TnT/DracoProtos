using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FLootItemDust : FLootItemDustBase
	{
		public override void SetSprite(RawImage rawImage)
		{
		}

		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.isStreak;
		}
	}
}
