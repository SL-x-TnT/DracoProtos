using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public abstract class FBaseLootItem : FBaseLootItemBase
	{
		public abstract void SetSprite(RawImage rawImage);

		public virtual string GetLootGroup()
		{
			return base.GetType().FullName;
		}
	}
}
