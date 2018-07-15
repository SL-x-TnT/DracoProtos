using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FLootItemBuff : FLootItemBuffBase
	{
		public override void SetSprite(RawImage rawImage)
		{
			//rawImage.texture = Prefabs.sprites.GetBuff(this.buff.type);
		}

		public override string GetLootGroup()
		{
			return string.Concat(new object[]
			{
				base.GetLootGroup(),
				"/",
				this.buff.type,
				"/",
				this.buff.valuePercent,
				"/",
				this.buff.durationMs
			});
		}
	}
}
