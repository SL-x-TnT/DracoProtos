using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FBagUpdate : FBagUpdateBase
	{
		protected bool Equals(FBagUpdate other)
		{
			return this.allowedItemsSize == other.allowedItemsSize && object.Equals(this.items, other.items) && object.Equals(this.lockedRunes, other.lockedRunes);
		}

		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FBagUpdate)obj)));
		}

		public override int GetHashCode()
		{
			int num = this.allowedItemsSize;
			num = (num * 397 ^ ((this.items == null) ? 0 : this.items.GetHashCode()));
			return num * 397 ^ ((this.lockedRunes == null) ? 0 : this.lockedRunes.GetHashCode());
		}
	}
}
