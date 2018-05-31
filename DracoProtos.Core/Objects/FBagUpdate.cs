using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
    public class FBagUpdate : FBagUpdateBase
    {

		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FBagUpdateBase)obj)));
		}

		public static bool operator ==(FBagUpdate left, FBagUpdate right)
		{
			return object.Equals(left, right);
		}

		public static bool operator !=(FBagUpdate left, FBagUpdate right)
		{
			return !object.Equals(left, right);
		}

        public override int GetHashCode()
        {
            //TODO:
            return 0;
        }
    }
}
