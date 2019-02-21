using DracoProtos.Core.Base;
using DracoProtos.Core.Extensions;

namespace DracoProtos.Core.Objects
{
    public class FUserCreaturesList : FUserCreaturesListBase
	{
		public override void Handle()
		{
		}

		protected bool Equals(FUserCreaturesListBase other)
		{
			return Utils.EnumerableEquals<FUserCreature>(this.userCreatures, other.userCreatures);
		}

		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FUserCreaturesListBase)obj)));
		}

		public override int GetHashCode()
		{
			return Utils.EnumerableHashCode<FUserCreature>(this.userCreatures, 0);
		}
	}
}
