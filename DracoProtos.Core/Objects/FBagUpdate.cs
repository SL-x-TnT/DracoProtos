using System;
using System.Collections.Generic;
using System.Linq;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FBagUpdate : FBagUpdateBase
	{
		protected bool Equals(FBagUpdate other)
		{
			return this.allowedItemsSize == other.allowedItemsSize && this.items.SequenceEqual(other.items) && this.lockedRunes.SequenceEqual(other.lockedRunes);
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
