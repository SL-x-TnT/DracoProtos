using DracoProtos.Core.Base;
using DracoProtos.Core.Extensions;

namespace DracoProtos.Core.Objects
{
    public class FCreadexEntry : FCreadexEntryBase
	{
		protected bool Equals(FCreadexEntryBase other)
		{
			return this.element == other.element && this.name == other.name && this.seen == other.seen && this.tier == other.tier && this.caughtQuantity == other.caughtQuantity && this.hasGolden == other.hasGolden && Utils.EnumerableEquals<FCreadexChain>(this.chain, other.chain);
		}

		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FCreadexEntryBase)obj)));
		}

		public override int GetHashCode()
		{
			int num = (int)this.element;
			num = (num * 397 ^ (int)this.name);
			num = (num * 397 ^ this.seen.GetHashCode());
			num = (num * 397 ^ this.tier);
			num = (num * 397 ^ this.caughtQuantity);
			num = (num * 397 ^ this.hasGolden.GetHashCode());
			return Utils.EnumerableHashCode<FCreadexChain>(this.chain, num);
		}

		public static bool operator ==(FCreadexEntry left, FCreadexEntry right)
		{
			return object.Equals(left, right);
		}

		public static bool operator !=(FCreadexEntry left, FCreadexEntry right)
		{
			return !object.Equals(left, right);
		}
	}
}
