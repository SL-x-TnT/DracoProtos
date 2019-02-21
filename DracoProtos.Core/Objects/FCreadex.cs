using DracoProtos.Core.Base;
using DracoProtos.Core.Extensions;

namespace DracoProtos.Core.Objects
{
    public class FCreadex : FCreadexBase
	{
		protected bool Equals(FCreadexBase other)
		{
			return Utils.EnumerableEquals<FCreadexEntry>(this.entries, other.entries);
		}

		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FCreadexBase)obj)));
		}

		public override int GetHashCode()
		{
			return Utils.EnumerableHashCode<FCreadexEntry>(this.entries, 0);
		}
	}
}
